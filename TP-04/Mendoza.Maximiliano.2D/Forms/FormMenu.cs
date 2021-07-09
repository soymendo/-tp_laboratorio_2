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

    

    public partial class FormMenu : Form
    {
        Fabrica fabrica = new Fabrica(10);
        FormIniciarPrueba cerrarHilos;


        public FormMenu()
        {
            InitializeComponent();

        }

        private void btnEnsamble_Click(object sender, EventArgs e)
        {
            FormEnsamblar formEnsamblar = new FormEnsamblar(fabrica);
            formEnsamblar.ShowDialog();
           

        }


        private void btnPrueba_Click(object sender, EventArgs e)
        {

            FormIniciarPrueba pruebas = new FormIniciarPrueba(fabrica);
            pruebas.Show();
            cerrarHilos = pruebas;
        }




        private void btnDepositos_Click(object sender, EventArgs e)
        {
            new FormDepositos(fabrica).ShowDialog();
        }

       

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            new FormArchivos(fabrica).ShowDialog();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            new FormSQL(fabrica).ShowDialog();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
