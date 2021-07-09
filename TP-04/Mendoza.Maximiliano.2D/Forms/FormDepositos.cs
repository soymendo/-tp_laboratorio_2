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







namespace Forms
{
    public partial class FormDepositos : Form
    {
        Fabrica fabrica;
        public FormDepositos(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;

            rtbListaEnsamblados.Text = fabrica.MostrarAlmacenGeneral();
            rtbListaEnsamblados.ReadOnly = true;
            lblTamanio.Text = fabrica.TamanioGeneral.ToString();

            rtbListaOk.Text = fabrica.MostrarDepositoOk();
            rtbListaOk.ReadOnly = true;
            lblTamanioOk.Text = fabrica.TamanioOk.ToString();

            lsbAReparar.DataSource = fabrica.ListaAReparar;
            lblTamanioAReparar.Text = fabrica.TamanioReparacion.ToString();

        }

        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            try
            {
                string text = rtbListaEnsamblados.Text;
                Texto texto = new Texto();


                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.txt", text);//guarda en escritorio
                MessageBox.Show("Archivo guardado en escritorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (ArchivoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarXml_Click(object sender, EventArgs e)
        {

            try
            {
                string text = rtbListaEnsamblados.Text;
                Xml<string> texto = new Xml<string>();
                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.xml", text);//guarda en escritorio
                MessageBox.Show("Archivo guardado en escritorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



                //string text = rtbListaEnsamblados.Text;
                //Binario<string> binary = new Binario<string>();
                //binary.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.bin",text);//guarda en escritorio
                //MessageBox.Show("Archivo guardado en escritorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                string text = rtbListaOk.Text;
                Texto texto = new Texto();


                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\CelularesOK.txt", text);//guarda en escritorio
                MessageBox.Show("Archivo guardado en escritorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArchivoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                string text = rtbListaOk.Text;
                Xml<string> texto = new Xml<string>();

                //texto.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Nombres.txt", text);
                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\CelularesOK.xml", text);//guarda en escritorio
                MessageBox.Show("Archivo guardado en escritorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArchivoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




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

                    //if(Fabrica.AlmacenadoEnDepositoOk(fabrica, (Celular)this.lsbAReparar.SelectedItem))
                    //{
                    //    MessageBox.Show("Ya se encuentra en DEPOSITO OK", "¡Funcionando OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

                    //else
                    //{
                        if (Fabrica.Reparacion(fabrica, (Celular)this.lsbAReparar.SelectedItem))
                        {
                            MessageBox.Show("Se realizó la REPARACION correctamente", "¡Funcionando OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            rtbListaOk.Text = fabrica.MostrarDepositoOk().ToString();
                            lblTamanioOk.Text = fabrica.TamanioOk.ToString();

                            lblTamanioAReparar.Text = fabrica.TamanioReparacion.ToString();

                        }

                        this.lsbAReparar.DataSource = null;
                        lsbAReparar.DataSource = fabrica.ListaAReparar;


                    //}
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
    }
}
