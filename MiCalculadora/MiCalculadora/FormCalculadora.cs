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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\FONDOHD.jpg");
            this.BackgroundImage = img;
        }

        /// <summary>
        /// Botón para Operar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void buttonOperar_Click(object sender, EventArgs e)
        {

          labelResultado.Text = FormCalculadora.Operar(textBoxNumero1.Text, textBoxNumero2.Text, comboBoxOperaciones.Text).ToString();
            buttonConvertirABinario.Enabled = true;
            buttonConvertirADecimal.Enabled = false;
        }


        /// <summary>
        /// Botón para el cierre del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            FormCalculadora.ActiveForm.Close();
        }


        /// <summary>
        /// Boton binario a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void buttonConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = Numero.DecimalABinario(labelResultado.Text);
            if (resultado != "Valor inválido")
                buttonConvertirADecimal.Enabled = true;
            labelResultado.Text = resultado;
            buttonConvertirABinario.Enabled = false;
        }

        /// <summary>
        /// Boton decimal a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonConvertirADecimal_Click(object sender, EventArgs e)
        {
            labelResultado.Text = Numero.BinarioDecimal(labelResultado.Text);
            buttonConvertirABinario.Enabled = true;
            buttonConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Botón para limpiar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Funcion privada y estática para realizar calculos.
        /// </summary>
        /// <param name="numero1">Numero para operar</param>
        /// <param name="numero2">Numero para operar</param>
        /// <param name="operador">Tipo de operador</param>
        /// <returns>Retorno resultado de operación</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            //Instancio los operadores con valores string
            Numero operando1 = new Numero(numero1);
            Numero operando2 = new Numero(numero2);
            //Retorno directamente la operacion solicitada
            return Calculadora.Operar(operando1, operando2, operador);
        }

        /// <summary>
        /// Método para limpiar el formulario.
        /// </summary>
        private void Limpiar()
        {
            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
            comboBoxOperaciones.ResetText();
            labelResultado.ResetText();
            buttonConvertirABinario.Enabled = false;
            buttonConvertirADecimal.Enabled = false;
            comboBoxOperaciones.Text = "Elija operacion";
            labelResultado.Text = "Resultado";
        }

     


        //----------Menu conceptual----------------
        /// <summary>
        /// Coloca un cero string 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxNumero2.Text = "0";
        }

        /// <summary>
        /// Coloca un numero aleatorio en el textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colocarNumeroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valor = rnd.Next(0, 100);
            textBoxNumero2.Text = valor.ToString();
        }

        /// <summary>
        /// Coloca un cero string 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNumero1.Text = "0";
        }

        /// <summary>
        /// Coloca un numero aleatorio en el textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colocarNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valor = rnd.Next(0, 100);
            textBoxNumero1.Text = valor.ToString();
        }

        //------------Entrada unicamente de numeros.---------------
        /// <summary>
        /// Permite al usuario ingresar solamente numeros dentro del textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)&& (e.KeyChar !=(char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
