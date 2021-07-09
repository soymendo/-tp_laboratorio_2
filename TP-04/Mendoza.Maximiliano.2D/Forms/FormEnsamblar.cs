using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Entidades.Clases_Generales;
using Entidades.Clases_Especializadas;
using Entidades.Archivos;
using Entidades.Exepciones;





namespace Forms
{
    public partial class FormEnsamblar : Form
    {
        Fabrica fabrica = new Fabrica(10);
        private Random codigo = new Random();
        private int cod;
        
       

        public FormEnsamblar(Fabrica fab)
        {
            InitializeComponent();
            this.fabrica = fab;
           
            cmbCarcaza.DataSource = Enum.GetValues(typeof(materiaPrima.ECarcaza));
            cmbBateria.DataSource = Enum.GetValues(typeof(materiaPrima.EBateria));
            cmbCamara.DataSource = Enum.GetValues(typeof(materiaPrima.ECamara));
            cmbPlaqueta.DataSource = Enum.GetValues(typeof(materiaPrima.EPlaquetaElectronica));
            txtCodigo.Enabled = false;


           


        }

        private void btnEnsamblar_Click(object sender, EventArgs e)
        {
            if (rbtAlcatel.Checked == false && rbtHuawei.Checked == false && rbtMotorola.Checked == false && rbtNokia.Checked == false && rbtSamsumg.Checked == false)
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
                             
                                //this.lsbEnsamblados.Items.Add(al);
                              
                              

                              
                                MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //MessageBox.Show(al.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);



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
                                //lsbEnsamblados.Items.Add(hu);
                                MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                                //lsbEnsamblados.Items.Add(no);
                                MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                                //lsbEnsamblados.Items.Add(mot);
                                MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                                //lsbEnsamblados.Items.Add(sam);
                                MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            txtCodigo.Text = "";
                            cmbCarcaza.Text = "";
                            cmbBateria.Text = "";
                            cmbCamara.Text = "";
                            cmbPlaqueta.Text = "";
                        }


                    }


                }

                //FormIniciarPrueba prueba = new FormIniciarPrueba(fabrica);
               // DialogResult re = prueba.ShowDialog();
                //FormDepositos dep = new FormDepositos(fabrica);
                //DialogResult otro = dep.ShowDialog();
                //rtbListaEnsamblados.Text = fabrica.MostrarAlmacenGeneral().ToString();

               // lblTamanio.Text = fabrica.TamanioGeneral.ToString();

            }



        }

        private void btnAgregarCodigo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = (codigo.Next(100000, 9999999)).ToString();
            cod = int.Parse(txtCodigo.Text);
        }

        private void cmbCarcaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbBateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCamara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPlaqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FormEnsamblar_Load(object sender, EventArgs e)
        {




        }
    }
}
