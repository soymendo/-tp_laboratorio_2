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
    public partial class FormArchivos : Form
    {
        public FormArchivos(Fabrica fab)
        {
            InitializeComponent();
            rtbArchivos.ReadOnly = true;

        }

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

                //Binario<string> binary = new Binario<string>();
                ////string nombres = "";
                //if (binary.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ensamblados.bin", out string nombres))
                //{
                //    rtbArchivos.Text = nombres;
                //}


            }

            catch (ArchivoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
