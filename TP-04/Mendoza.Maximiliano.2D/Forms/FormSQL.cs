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
   
    public partial class FormSQL : Form
    {

        public delegate void Aviso();
        public event Aviso Cartel;

        Fabrica fabrica = new Fabrica(10);
        private Random codigo = new Random();
        private int cod;
        CelularesDAO celuDao = new CelularesDAO();

       
       

        public FormSQL(Fabrica fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;

            cmbCarcaza.DataSource = Enum.GetValues(typeof(materiaPrima.ECarcaza));
            cmbBateria.DataSource = Enum.GetValues(typeof(materiaPrima.EBateria));
            cmbCamara.DataSource = Enum.GetValues(typeof(materiaPrima.ECamara));
            cmbPlaqueta.DataSource = Enum.GetValues(typeof(materiaPrima.EPlaquetaElectronica));
            txtCodigo.Enabled = false;
            rtbInfo.ReadOnly = true;

       
            this.Cartel += inicializarCmb;
           

        }

        private void FormSQL_Load(object sender, EventArgs e)
        {
            Cartel.Invoke();
        }

        private void campoSinSeleccionar()
        {
            MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void elementoSinSeleccionar()
        {
            MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void inicializarCmb()
        {

            txtCodigo.Text = "";
            cmbCarcaza.Text = "";
            cmbBateria.Text = "";
            cmbCamara.Text = "";
            cmbPlaqueta.Text = "";
        }





        /// <summary>
        /// Guarda en labase de datos el celu creado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarBaseDeDatos_Click(object sender, EventArgs e)
        {
            if (rbtAlcatel.Checked == false && rbtHuawei.Checked == false && rbtMotorola.Checked == false && rbtNokia.Checked == false && rbtSamsumg.Checked == false)
            {
                
                campoSinSeleccionar();
               // MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Control control in this.pnlTipos.Controls) //uso panel
                {
                    if (control is RadioButton && ((RadioButton)control).Checked && rbtAlcatel.Checked)
                    {
                        if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                        {
                            campoSinSeleccionar();
                           // MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                Alcatel al = new Alcatel(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));

                                


                                MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                celuDao.InsertarProducto(al);


                                inicializarCmb();
                                //txtCodigo.Text = "";
                                //cmbCarcaza.Text = "";
                                //cmbBateria.Text = "";
                                //cmbCamara.Text = "";
                                //cmbPlaqueta.Text = "";
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }



                        }


                    }


                    if (control is RadioButton && ((RadioButton)control).Checked && rbtHuawei.Checked)
                    {

                        if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                        {
                            campoSinSeleccionar();
                            //MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                Huawei hu = new Huawei(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));

                                celuDao.InsertarProducto(hu);
                               
                                MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                inicializarCmb();
                                //txtCodigo.Text = "";
                                //cmbCarcaza.Text = "";
                                //cmbBateria.Text = "";
                                //cmbCamara.Text = "";
                                //cmbPlaqueta.Text = "";
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }


                    }



                    if (control is RadioButton && ((RadioButton)control).Checked && rbtNokia.Checked)
                    {


                        if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                        {

                            campoSinSeleccionar();
                            //MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        }
                        }
                        else
                        {
                            try
                            {
                                Nokia no = new Nokia(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));
                                celuDao.InsertarProducto(no);



                                MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                inicializarCmb();
                                //txtCodigo.Text = "";
                                //cmbCarcaza.Text = "";
                                //cmbBateria.Text = "";
                                //cmbCamara.Text = "";
                                //cmbPlaqueta.Text = "";
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }



                    }

                    if (control is RadioButton && ((RadioButton)control).Checked && rbtMotorola.Checked)
                    {

                            if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                            {

                                campoSinSeleccionar();
                                //MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        }
                            }
                            else
                            {
                                try
                                {
                                    Motorola mot = new Motorola(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));
                                    celuDao.InsertarProducto(mot);


                                    MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                inicializarCmb();
                                //txtCodigo.Text = "";
                                //cmbCarcaza.Text = "";
                                //cmbBateria.Text = "";
                                //cmbCamara.Text = "";
                                //cmbPlaqueta.Text = "";
                            }
                            catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }

                            }


                    }

                    if (control is RadioButton && ((RadioButton)control).Checked && rbtSamsumg.Checked)
                    {

                                if (txtCodigo.Text == "" || cmbCarcaza.Text == "" || cmbBateria.Text == "" || cmbCamara.Text == "" || cmbPlaqueta.Text == "")
                                {

                                    campoSinSeleccionar();
                                    //MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        }
                                }
                                else
                                {
                                    try
                                    {
                                        Samsumg sam = new Samsumg(cod, ((Entidades.Clases_Generales.materiaPrima.ECarcaza)cmbCarcaza.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EBateria)cmbBateria.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.ECamara)cmbCamara.SelectedItem), ((Entidades.Clases_Generales.materiaPrima.EPlaquetaElectronica)cmbPlaqueta.SelectedItem));
                                        celuDao.InsertarProducto(sam);

                                        MessageBox.Show("Ensamblado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



                                inicializarCmb();
                                //txtCodigo.Text = "";
                                //cmbCarcaza.Text = "";
                                //cmbBateria.Text = "";
                                //cmbCamara.Text = "";
                                //cmbPlaqueta.Text = "";
                            }
                            catch (Exception ex)
                                    {

                                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }

                                }


                    }


                }

                

            }

        
        
        }












        private void btnAgregarCodigo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = (codigo.Next(100000, 999999)).ToString();
            cod = int.Parse(txtCodigo.Text);
        }


        /// <summary>
        /// elimina un celular de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarDeBaseDeDatos_Click(object sender, EventArgs e)
        {
            Celular cel;
            int codigo;
           
            if (lsbArmadoExterno.SelectedItem == null)
            {
                elementoSinSeleccionar();
               // MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                cel = (Celular)(this.lsbArmadoExterno.SelectedItem);
                codigo = cel.CodigoDeBarras;
                // celuDao.Borrar(((Celular)(this.lsbArmadoExterno.SelectedItem)).CodigoDeBarras);
                celuDao.Borrar(codigo);
                this.lsbArmadoExterno.Items.Remove((Celular)(this.lsbArmadoExterno.SelectedItem));
                MessageBox.Show("Eliminado  de la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbInfo.Text = "";
            }
              
        }


        /// <summary>
        /// invalida el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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




        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.lsbArmadoExterno.Items.Clear();
                //  List<Celular> celulares = celuDao.Leer();
                List<Celular> celulares = celuDao.MostrarBD(); //metodo de extension
                foreach (Celular item in celulares)
                {                 
                    this.lsbArmadoExterno.Items.Add(item);                 
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


        private void lsbArmadoExterno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Celular cel;

            cel = (Celular)lsbArmadoExterno.SelectedItem;


            if (lsbArmadoExterno.SelectedItem == null)
            {

                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                rtbInfo.Text = cel.Info();
                //rtbInfo.Text = cel.ToString();
            }
          
           
        }

        private void btnGuardarEnDepositoEnsamblados_Click(object sender, EventArgs e)
        {

            if (lsbArmadoExterno.SelectedItem == null)
            {

                elementoSinSeleccionar();
                //MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if ((Fabrica.AlmacenadoEnEnsamblados(fabrica, (Celular)(this.lsbArmadoExterno.SelectedItem))))
                {
                    MessageBox.Show("Ya se encuentra almacenado en depositoEnsamblados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Fabrica.GuardarEnDepositoEnsamblados(fabrica, (Celular)(this.lsbArmadoExterno.SelectedItem)))
                    {
                        MessageBox.Show("Guardado en ENSAMBLADOS", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


        }

       

        
    }

}

