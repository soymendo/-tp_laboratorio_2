using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Entidades;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Clases_Generales;
using Entidades.Clases_Especializadas;
using Entidades.Archivos;
using Entidades.Exepciones;
using System.Threading;

namespace Forms
{
    public partial class FormIniciarPrueba : Form
    {
        private Thread hiloSecundario;
        public delegate void Cargar();
        public event Cargar CargarLista;
        public delegate void EnEspera(object sender);

        Celular celu;
        Fabrica fabrica;
        private Random aleatorio = new Random();
        int numerito;

      
        private int conteo=1;

        public FormIniciarPrueba(Fabrica fabrica)
        {
            InitializeComponent();
            conteo = 0;
            this.fabrica = fabrica;
            this.CargarLista += FormIniciarPrueba_CargarLista;
            CargarLista.Invoke();

       
        }

        private void FormIniciarPrueba_CargarLista()
        {
            Alcatel al = new Alcatel(123456, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Grande, materiaPrima.ECamara.ultraHD, materiaPrima.EPlaquetaElectronica.SerieA);
            Huawei huw = new Huawei(256893, materiaPrima.ECarcaza.Plastico, materiaPrima.EBateria.Litio, materiaPrima.ECamara.Standar, materiaPrima.EPlaquetaElectronica.SerieH);
            Motorola mot = new Motorola(254569, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Mediana, materiaPrima.ECamara.fullHD, materiaPrima.EPlaquetaElectronica.SerieM);
            Nokia nok = new Nokia(982566, materiaPrima.ECarcaza.Plastico, materiaPrima.EBateria.Mediana, materiaPrima.ECamara.ultraHD, materiaPrima.EPlaquetaElectronica.SerieN);
            Samsumg sumg = new Samsumg(547890, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Litio, materiaPrima.ECamara.Standar, materiaPrima.EPlaquetaElectronica.SerieS);

            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, al)) { }
           
            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, huw)) { }
          
            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, mot)) { }
           
            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, nok)) { }
           
            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, sumg)) { }
        
            lsbEnsamblados.DataSource = fabrica.ListaEnsamblados;// cargo la lista de celulares ensamblados

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>

        public void Espera(object sender)
        {
            //Thread.Sleep(5000);
            if (lsbEnsamblados.InvokeRequired)
            {
                EnEspera espera = new EnEspera(Espera);
                object[] args = new object[] { sender};
                this.Invoke(espera,args);
            }
            else
            {
                try
                {
                    numerito = aleatorio.Next(1, 3);
                    if (lsbEnsamblados.SelectedItem == null)
                    {
                       MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        else
                        {
                            if (Fabrica.IniciarPruebaDeCalidad(fabrica, (Celular)this.lsbEnsamblados.SelectedItem, numerito))
                            {                             
                            }
                        }  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }



        /// <summary>
        /// dara inicia a un nuevo hilo en el cual se hara el proceso de prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnHacerTest_Click(object sender, EventArgs e)
        {
          
            if (pgbBarra.Value>0 && pgbBarra.Value != pgbBarra.Maximum)
            {
                MessageBox.Show("El proceso todavia no termino, aguarde");
                btnHacerTest.Enabled = false;
            }
            else
            {
                if ((Fabrica.AlmacenadoEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem)) || (Fabrica.AlmacenadoEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem)))
                {

                    //si no esta almacenado en areparar, sigo.
                    if ((Fabrica.AlmacenadoEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem)))
                    {
                        MessageBox.Show("Ya se encuentra almacenado en depositoAreparar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ya se encuentra almacenado en depositoOk", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    timer.Enabled = true;
                    pgbBarra.Value = 0;
                }

                this.hiloSecundario = new Thread(new ParameterizedThreadStart(Espera));
                hiloSecundario.Start();

            }





        }

       
        /// <summary>
        /// timer usado para el progressbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            
             conteo++;
           
            lblProceso.Text =  "Procesando..." + conteo.ToString() + "%";
            if(pgbBarra.Value<100)
            {
                pgbBarra.Value++;
                //progressBar1.PerformStep();
            }
            if (pgbBarra.Value == 100)
            {
                timer.Enabled = false;
                conteo = 0;
                MessageBox.Show("Se realizó la prueba del dispositivo correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Fabrica.AlmacenadoEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                {
                    MessageBox.Show("Almacenado en Deposito Ok", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Almacenado en Deposito A Reparar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnHacerTest.Enabled = true;
                
            }
        }



      

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (Fabrica.AlmacenadoEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
        //    {
        //        if (Fabrica.EliminarEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
        //        {
        //            MessageBox.Show("Eliminado en Deposito Ok", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (Fabrica.AlmacenadoEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
        //    {
        //        if (Fabrica.EliminarEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
        //        {
        //            MessageBox.Show("Eliminado en Deposito A Reparar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //    }
        //}

      

        private void FormIniciarPrueba_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pgbBarra.Value!=pgbBarra.Maximum && this.hiloSecundario!=null && this.hiloSecundario.IsAlive)
            {


                if (Fabrica.AlmacenadoEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                {
                    if (Fabrica.EliminarEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                    {
                       // MessageBox.Show("Eliminado en Deposito Ok", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                if (Fabrica.AlmacenadoEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                {
                    if (Fabrica.EliminarEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                    {
                        //MessageBox.Show("Eliminado en Deposito A Reparar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                this.hiloSecundario.Abort();
                timer.Stop();
            }



            if (pgbBarra.Value != pgbBarra.Maximum )
            {

                //areglar cuando cierro y queda en reparacion o ok

                if (Fabrica.AlmacenadoEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                {
                    if (Fabrica.EliminarEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                    {
                        // MessageBox.Show("Eliminado en Deposito Ok", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                if (Fabrica.AlmacenadoEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                {
                    if (Fabrica.EliminarEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                    {
                        //MessageBox.Show("Eliminado en Deposito A Reparar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
               
                timer.Stop();
            }





        }
    }
}
