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

namespace Formulario
{
    public partial class Formulario : Form
    {
        Fabrica fabrica = new Fabrica(10);
      
        private Random codigo = new Random();
        private int cod;
        private Random aleatorio = new Random();
        int numerito;
        public Formulario()
        {
            InitializeComponent();
          

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\FONDOHD.png");
            this.BackgroundImage = img;
            cmbCarcaza.DataSource = Enum.GetValues(typeof(materiaPrima.ECarcaza));
            cmbBateria.DataSource = Enum.GetValues(typeof(materiaPrima.EBateria));
            cmbCamara.DataSource = Enum.GetValues(typeof(materiaPrima.ECamara));
            cmbPlaqueta.DataSource = Enum.GetValues(typeof(materiaPrima.EPlaquetaElectronica));
            txtCodigo.Enabled = false;

        }


        /// <summary>
        /// Evento load
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Formulario_Load(object sender, EventArgs e)
        {

            Alcatel al = new Alcatel(123456, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Grande, materiaPrima.ECamara.ultraHD, materiaPrima.EPlaquetaElectronica.SerieA);
            Huawei huw = new Huawei(256893, materiaPrima.ECarcaza.Plastico, materiaPrima.EBateria.Litio, materiaPrima.ECamara.standar, materiaPrima.EPlaquetaElectronica.SerieH);
            Motorola mot = new Motorola(254569, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Mediana, materiaPrima.ECamara.fullHD, materiaPrima.EPlaquetaElectronica.SerieM);
            Nokia nok = new Nokia(982566, materiaPrima.ECarcaza.Plastico, materiaPrima.EBateria.Mediana, materiaPrima.ECamara.ultraHD, materiaPrima.EPlaquetaElectronica.SerieN);
            Samsumg sumg = new Samsumg(547890, materiaPrima.ECarcaza.Metal, materiaPrima.EBateria.Litio, materiaPrima.ECamara.standar, materiaPrima.EPlaquetaElectronica.SerieS);

            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, al)) { }

            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, huw)) { }

            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, mot)) { }

            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, nok)) { }

            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, sumg)) { }


            lsbEnsamblados.Items.Add(al);
            lsbEnsamblados.Items.Add(huw);
            lsbEnsamblados.Items.Add(mot);
            lsbEnsamblados.Items.Add(nok);
            lsbEnsamblados.Items.Add(sumg);

            rtbListaEnsamblados.Text = fabrica.MostrarAlmacenGeneral().ToString();

            lblTamanio.Text = fabrica.TamanioGeneral.ToString();

        }





        /// <summary>
        /// Boton que agrega un numero aleatoria al txtCodigo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btbAgregar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = (codigo.Next(100000, 9999999)).ToString();
            cod = int.Parse(txtCodigo.Text);
        }

        /// <summary>
        /// Boton que crea una instancia de un tipo heredado Celular escogida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnsamblar_Click(object sender, EventArgs e)
        {
            if(rbtAlcatel.Checked==false && rbtHuawei.Checked == false && rbtMotorola.Checked == false && rbtNokia.Checked == false && rbtSamsumg.Checked == false )
            {
                MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Control control in this.pnlTipos.Controls) //uso panel
                {
                    if (control is RadioButton && ((RadioButton)control).Checked && rbtAlcatel.Checked)
                    {
                        if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                        {

                            MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            Alcatel al = new Alcatel(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));

                            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, al))
                            {
                                lsbEnsamblados.Items.Add(al);
                            }
                            txtCodigo.Text = "";
                            cmbCarcaza.Text = "";
                            cmbBateria.Text = "";
                            cmbCamara.Text = "";
                            cmbPlaqueta.Text = "";



                        }

                    }


                    if (control is RadioButton && ((RadioButton)control).Checked && rbtHuawei.Checked)
                    {

                        if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                        {

                            MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Huawei hu = new Huawei(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));

                            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, hu))
                            {
                                lsbEnsamblados.Items.Add(hu);
                            }
                            txtCodigo.Text = "";
                            cmbCarcaza.Text = "";
                            cmbBateria.Text = "";
                            cmbCamara.Text = "";
                            cmbPlaqueta.Text = "";
                        }


                    }



                    if (control is RadioButton && ((RadioButton)control).Checked && rbtNokia.Checked)
                    {


                        if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                        {

                            MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Nokia no = new Nokia(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));


                            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, no))
                            {
                                lsbEnsamblados.Items.Add(no);
                            }
                            txtCodigo.Text = "";
                            cmbCarcaza.Text = "";
                            cmbBateria.Text = "";
                            cmbCamara.Text = "";
                            cmbPlaqueta.Text = "";
                        }



                    }

                    if (control is RadioButton && ((RadioButton)control).Checked && rbtMotorola.Checked)
                    {

                        if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                        {

                            MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Motorola mot = new Motorola(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));


                            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, mot))
                            {
                                lsbEnsamblados.Items.Add(mot);
                            }
                            txtCodigo.Text = "";
                            cmbCarcaza.Text = "";
                            cmbBateria.Text = "";
                            cmbCamara.Text = "";
                            cmbPlaqueta.Text = "";
                        }


                    }

                    if (control is RadioButton && ((RadioButton)control).Checked && rbtSamsumg.Checked)
                    {

                        if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                        {

                            MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Samsumg sam = new Samsumg(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));

                            if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, sam))
                            {
                                lsbEnsamblados.Items.Add(sam);
                            }
                            txtCodigo.Text = "";
                            cmbCarcaza.Text = "";
                            cmbBateria.Text = "";
                            cmbCamara.Text = "";
                            cmbPlaqueta.Text = "";
                        }


                    }

                }

                rtbListaEnsamblados.Text = fabrica.MostrarAlmacenGeneral().ToString();

                lblTamanio.Text = fabrica.TamanioGeneral.ToString();

            }





        }

        private void btnHacerTest_Click(object sender, EventArgs e)
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
                    if ((Fabrica.AlmacenadoEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem)))
                    {
                        //si no esta almacenado en areparar, sigo.
                    }
                    else
                    {
                        if (Fabrica.IniciarPruebaDeCalidad(fabrica, (Celular)this.lsbEnsamblados.SelectedItem, numerito))
                        {
                            MessageBox.Show("Se realizó la prueba del dispositivo correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (Fabrica.AlmacenadoEnDepositoOk(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                            {
                                MessageBox.Show("Almacenado en Deposito Ok", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Almacenado en Deposito A Reparar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                          
                            rtbListaOk.Text = fabrica.MostrarDepositoOk().ToString();
                            lblTamanioOk.Text = fabrica.TamanioOk.ToString();

                            lblTamanioAReparar.Text = fabrica.TamanioReparacion.ToString();

                            //me fijo si ese celu esta en reparacion y lo agrego al listbox de reparacion
                            if (Fabrica.AlmacenadoEnDepositoAReparar(fabrica, (Celular)this.lsbEnsamblados.SelectedItem))
                            {
                                lsbAReparar.Items.Add((Celular)this.lsbEnsamblados.SelectedItem);
                            }


                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /// <summary>
        /// Boton que simula la reparacion del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReparar_Click(object sender, EventArgs e)
        {

            try
            {
                if (lsbAReparar.SelectedItem == null)
                {

                    MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Fabrica.Reparacion(fabrica, (Celular)this.lsbAReparar.SelectedItem))
                    {
                        MessageBox.Show("Se realizó la REPARACION correctamente", "¡Funcionando OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lsbAReparar.Items.Remove((Celular)this.lsbAReparar.SelectedItem);

                        rtbListaOk.Text = fabrica.MostrarDepositoOk().ToString();
                        lblTamanioOk.Text = fabrica.TamanioOk.ToString();

                        lblTamanioAReparar.Text = fabrica.TamanioReparacion.ToString();

                    }
                }

            }
            catch (Exception )
            {
                MessageBox.Show("Debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        /// <summary>
        /// Guarda la lista de ensamblados en el escritorio
        /// en formato txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            try
            {
                string text = rtbListaEnsamblados.Text;
                Texto texto = new Texto();


                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.txt", text);//guarda en escritorio



            }
            catch (ArchivoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Guarda la lista de ensamblados en el escritorio
        /// en formato xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarXml_Click(object sender, EventArgs e)
        {
            try
            {
                string text = rtbListaEnsamblados.Text;
                Xml<string> texto = new Xml<string>();

               
                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.xml", text);//guarda en escritorio
            }
            catch (ArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// guarda la lista de productos ok en el escritorio
        /// en formato txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                string text = rtbListaOk.Text;
                Texto texto = new Texto();

               
                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\CelularesOK.txt", text);//guarda en escritorio
            }
            catch (ArchivoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// guarda la lista de productos ok en el escritorio
        /// en formato xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                string text = rtbListaOk.Text;
                Xml<string> texto = new Xml<string>();

                //texto.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Nombres.txt", text);
                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\CelularesOK.xml", text);//guarda en escritorio
            }
            catch (ArchivoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// lee un archivo  de formato txt desde el escritorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeerTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto texto = new Texto();
               
                if (texto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.txt", out string nombres))
                {
                    rtbArchivos.Text = nombres;
                }
               
            }

            catch (ArchivoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// lee un archivo  de formato xml desde el escritorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeerXML_Click(object sender, EventArgs e)
        {
            try
            {
                Xml<string> texto = new Xml<string>();
                //string nombres = "";
                if (texto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.xml", out string nombres))
                {
                    rtbArchivos.Text = nombres;
                }
                
            }

            catch (ArchivoException ex)
            {
               
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
