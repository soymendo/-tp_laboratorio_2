
namespace Formulario
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlEnsamble = new System.Windows.Forms.Panel();
            this.cmbPlaqueta = new System.Windows.Forms.ComboBox();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.cmbBateria = new System.Windows.Forms.ComboBox();
            this.cmbCarcaza = new System.Windows.Forms.ComboBox();
            this.btnEnsamblar = new System.Windows.Forms.Button();
            this.pnlTipos = new System.Windows.Forms.Panel();
            this.rbtSamsumg = new System.Windows.Forms.RadioButton();
            this.rbtNokia = new System.Windows.Forms.RadioButton();
            this.rbtHuawei = new System.Windows.Forms.RadioButton();
            this.rbtMotorola = new System.Windows.Forms.RadioButton();
            this.rbtAlcatel = new System.Windows.Forms.RadioButton();
            this.btbAgregar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblplaqueta = new System.Windows.Forms.Label();
            this.lblCamara = new System.Windows.Forms.Label();
            this.lblBateria = new System.Windows.Forms.Label();
            this.lblCarcaza = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlOk = new System.Windows.Forms.Panel();
            this.lblTamanioOk = new System.Windows.Forms.Label();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.rtbListaOk = new System.Windows.Forms.RichTextBox();
            this.lblOk = new System.Windows.Forms.Label();
            this.pnlEnsamblados = new System.Windows.Forms.Panel();
            this.btnGuardarXml = new System.Windows.Forms.Button();
            this.btnGuardarTxt = new System.Windows.Forms.Button();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.rtbListaEnsamblados = new System.Windows.Forms.RichTextBox();
            this.lblListaEnsamblados = new System.Windows.Forms.Label();
            this.pnlListaEnsamblados = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbEnsamblados = new System.Windows.Forms.ListBox();
            this.btnHacerTest = new System.Windows.Forms.Button();
            this.lblEnsamblados = new System.Windows.Forms.Label();
            this.pnlAReparar = new System.Windows.Forms.Panel();
            this.lsbAReparar = new System.Windows.Forms.ListBox();
            this.lblTamanioAReparar = new System.Windows.Forms.Label();
            this.btnReparar = new System.Windows.Forms.Button();
            this.lblAReparar = new System.Windows.Forms.Label();
            this.pnlArchivos = new System.Windows.Forms.Panel();
            this.btnLeerTxt = new System.Windows.Forms.Button();
            this.btnLeerXML = new System.Windows.Forms.Button();
            this.rtbArchivos = new System.Windows.Forms.RichTextBox();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlEnsamble.SuspendLayout();
            this.pnlTipos.SuspendLayout();
            this.pnlOk.SuspendLayout();
            this.pnlEnsamblados.SuspendLayout();
            this.pnlListaEnsamblados.SuspendLayout();
            this.pnlAReparar.SuspendLayout();
            this.pnlArchivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEnsamble
            // 
            this.pnlEnsamble.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlEnsamble.Controls.Add(this.cmbPlaqueta);
            this.pnlEnsamble.Controls.Add(this.cmbCamara);
            this.pnlEnsamble.Controls.Add(this.cmbBateria);
            this.pnlEnsamble.Controls.Add(this.cmbCarcaza);
            this.pnlEnsamble.Controls.Add(this.btnEnsamblar);
            this.pnlEnsamble.Controls.Add(this.pnlTipos);
            this.pnlEnsamble.Controls.Add(this.btbAgregar);
            this.pnlEnsamble.Controls.Add(this.txtCodigo);
            this.pnlEnsamble.Controls.Add(this.lblplaqueta);
            this.pnlEnsamble.Controls.Add(this.lblCamara);
            this.pnlEnsamble.Controls.Add(this.lblBateria);
            this.pnlEnsamble.Controls.Add(this.lblCarcaza);
            this.pnlEnsamble.Controls.Add(this.lblCodigo);
            this.pnlEnsamble.Location = new System.Drawing.Point(21, 13);
            this.pnlEnsamble.Name = "pnlEnsamble";
            this.pnlEnsamble.Size = new System.Drawing.Size(377, 316);
            this.pnlEnsamble.TabIndex = 0;
            // 
            // cmbPlaqueta
            // 
            this.cmbPlaqueta.FormattingEnabled = true;
            this.cmbPlaqueta.Location = new System.Drawing.Point(253, 122);
            this.cmbPlaqueta.Name = "cmbPlaqueta";
            this.cmbPlaqueta.Size = new System.Drawing.Size(102, 21);
            this.cmbPlaqueta.TabIndex = 16;
            this.cmbPlaqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPlaqueta_KeyPress);
            // 
            // cmbCamara
            // 
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(253, 95);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(102, 21);
            this.cmbCamara.TabIndex = 15;
            this.cmbCamara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCamara_KeyPress);
            // 
            // cmbBateria
            // 
            this.cmbBateria.FormattingEnabled = true;
            this.cmbBateria.Location = new System.Drawing.Point(253, 70);
            this.cmbBateria.Name = "cmbBateria";
            this.cmbBateria.Size = new System.Drawing.Size(102, 21);
            this.cmbBateria.TabIndex = 14;
            this.cmbBateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBateria_KeyPress);
            // 
            // cmbCarcaza
            // 
            this.cmbCarcaza.FormattingEnabled = true;
            this.cmbCarcaza.Location = new System.Drawing.Point(253, 43);
            this.cmbCarcaza.Name = "cmbCarcaza";
            this.cmbCarcaza.Size = new System.Drawing.Size(102, 21);
            this.cmbCarcaza.TabIndex = 13;
            this.cmbCarcaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCarcaza_KeyPress);
            // 
            // btnEnsamblar
            // 
            this.btnEnsamblar.Location = new System.Drawing.Point(15, 271);
            this.btnEnsamblar.Name = "btnEnsamblar";
            this.btnEnsamblar.Size = new System.Drawing.Size(103, 23);
            this.btnEnsamblar.TabIndex = 12;
            this.btnEnsamblar.Text = "Ensamblar";
            this.btnEnsamblar.UseVisualStyleBackColor = true;
            this.btnEnsamblar.Click += new System.EventHandler(this.btnEnsamblar_Click);
            // 
            // pnlTipos
            // 
            this.pnlTipos.Controls.Add(this.rbtSamsumg);
            this.pnlTipos.Controls.Add(this.rbtNokia);
            this.pnlTipos.Controls.Add(this.rbtHuawei);
            this.pnlTipos.Controls.Add(this.rbtMotorola);
            this.pnlTipos.Controls.Add(this.rbtAlcatel);
            this.pnlTipos.Location = new System.Drawing.Point(19, 173);
            this.pnlTipos.Name = "pnlTipos";
            this.pnlTipos.Size = new System.Drawing.Size(310, 73);
            this.pnlTipos.TabIndex = 11;
            // 
            // rbtSamsumg
            // 
            this.rbtSamsumg.AutoSize = true;
            this.rbtSamsumg.Location = new System.Drawing.Point(170, 38);
            this.rbtSamsumg.Name = "rbtSamsumg";
            this.rbtSamsumg.Size = new System.Drawing.Size(71, 17);
            this.rbtSamsumg.TabIndex = 4;
            this.rbtSamsumg.TabStop = true;
            this.rbtSamsumg.Text = "Samsumg";
            this.rbtSamsumg.UseVisualStyleBackColor = true;
            // 
            // rbtNokia
            // 
            this.rbtNokia.AutoSize = true;
            this.rbtNokia.Location = new System.Drawing.Point(210, 15);
            this.rbtNokia.Name = "rbtNokia";
            this.rbtNokia.Size = new System.Drawing.Size(53, 17);
            this.rbtNokia.TabIndex = 2;
            this.rbtNokia.TabStop = true;
            this.rbtNokia.Text = "Nokia";
            this.rbtNokia.UseVisualStyleBackColor = true;
            // 
            // rbtHuawei
            // 
            this.rbtHuawei.AutoSize = true;
            this.rbtHuawei.Location = new System.Drawing.Point(119, 15);
            this.rbtHuawei.Name = "rbtHuawei";
            this.rbtHuawei.Size = new System.Drawing.Size(61, 17);
            this.rbtHuawei.TabIndex = 1;
            this.rbtHuawei.TabStop = true;
            this.rbtHuawei.Text = "Huawei";
            this.rbtHuawei.UseVisualStyleBackColor = true;
            // 
            // rbtMotorola
            // 
            this.rbtMotorola.AutoSize = true;
            this.rbtMotorola.Location = new System.Drawing.Point(51, 38);
            this.rbtMotorola.Name = "rbtMotorola";
            this.rbtMotorola.Size = new System.Drawing.Size(66, 17);
            this.rbtMotorola.TabIndex = 3;
            this.rbtMotorola.TabStop = true;
            this.rbtMotorola.Text = "Motorola";
            this.rbtMotorola.UseVisualStyleBackColor = true;
            // 
            // rbtAlcatel
            // 
            this.rbtAlcatel.AutoSize = true;
            this.rbtAlcatel.Location = new System.Drawing.Point(14, 15);
            this.rbtAlcatel.Name = "rbtAlcatel";
            this.rbtAlcatel.Size = new System.Drawing.Size(57, 17);
            this.rbtAlcatel.TabIndex = 0;
            this.rbtAlcatel.TabStop = true;
            this.rbtAlcatel.Text = "Alcatel";
            this.rbtAlcatel.UseVisualStyleBackColor = true;
            // 
            // btbAgregar
            // 
            this.btbAgregar.Location = new System.Drawing.Point(129, 15);
            this.btbAgregar.Name = "btbAgregar";
            this.btbAgregar.Size = new System.Drawing.Size(75, 26);
            this.btbAgregar.TabIndex = 6;
            this.btbAgregar.Text = "Agregar";
            this.btbAgregar.UseVisualStyleBackColor = true;
            this.btbAgregar.Click += new System.EventHandler(this.btbAgregar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(253, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(102, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblplaqueta
            // 
            this.lblplaqueta.AutoSize = true;
            this.lblplaqueta.Location = new System.Drawing.Point(14, 130);
            this.lblplaqueta.Name = "lblplaqueta";
            this.lblplaqueta.Size = new System.Drawing.Size(49, 13);
            this.lblplaqueta.TabIndex = 4;
            this.lblplaqueta.Text = "Plaqueta";
            // 
            // lblCamara
            // 
            this.lblCamara.AutoSize = true;
            this.lblCamara.Location = new System.Drawing.Point(14, 103);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(43, 13);
            this.lblCamara.TabIndex = 3;
            this.lblCamara.Text = "Camara";
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.Location = new System.Drawing.Point(14, 74);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(40, 13);
            this.lblBateria.TabIndex = 2;
            this.lblBateria.Text = "Bateria";
            // 
            // lblCarcaza
            // 
            this.lblCarcaza.AutoSize = true;
            this.lblCarcaza.Location = new System.Drawing.Point(14, 46);
            this.lblCarcaza.Name = "lblCarcaza";
            this.lblCarcaza.Size = new System.Drawing.Size(46, 13);
            this.lblCarcaza.TabIndex = 1;
            this.lblCarcaza.Text = "Carcaza";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo de barras";
            // 
            // pnlOk
            // 
            this.pnlOk.BackColor = System.Drawing.Color.LightCyan;
            this.pnlOk.Controls.Add(this.lblTamanioOk);
            this.pnlOk.Controls.Add(this.btnTxt);
            this.pnlOk.Controls.Add(this.btnXml);
            this.pnlOk.Controls.Add(this.rtbListaOk);
            this.pnlOk.Controls.Add(this.lblOk);
            this.pnlOk.Location = new System.Drawing.Point(774, 357);
            this.pnlOk.Name = "pnlOk";
            this.pnlOk.Size = new System.Drawing.Size(239, 316);
            this.pnlOk.TabIndex = 1;
            // 
            // lblTamanioOk
            // 
            this.lblTamanioOk.AutoSize = true;
            this.lblTamanioOk.Location = new System.Drawing.Point(8, 241);
            this.lblTamanioOk.Name = "lblTamanioOk";
            this.lblTamanioOk.Size = new System.Drawing.Size(46, 13);
            this.lblTamanioOk.TabIndex = 10;
            this.lblTamanioOk.Text = "Tamaño";
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(11, 257);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(160, 23);
            this.btnTxt.TabIndex = 9;
            this.btnTxt.Text = "Guardar OK Txt";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(11, 286);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(160, 23);
            this.btnXml.TabIndex = 8;
            this.btnXml.Text = "Guardar OK XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // rtbListaOk
            // 
            this.rtbListaOk.Location = new System.Drawing.Point(23, 43);
            this.rtbListaOk.Name = "rtbListaOk";
            this.rtbListaOk.Size = new System.Drawing.Size(160, 190);
            this.rtbListaOk.TabIndex = 4;
            this.rtbListaOk.Text = "";
            // 
            // lblOk
            // 
            this.lblOk.AutoSize = true;
            this.lblOk.Location = new System.Drawing.Point(18, 15);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(47, 13);
            this.lblOk.TabIndex = 3;
            this.lblOk.Text = "Lista OK";
            // 
            // pnlEnsamblados
            // 
            this.pnlEnsamblados.BackColor = System.Drawing.Color.LightCyan;
            this.pnlEnsamblados.Controls.Add(this.btnGuardarXml);
            this.pnlEnsamblados.Controls.Add(this.btnGuardarTxt);
            this.pnlEnsamblados.Controls.Add(this.lblTamanio);
            this.pnlEnsamblados.Controls.Add(this.rtbListaEnsamblados);
            this.pnlEnsamblados.Controls.Add(this.lblListaEnsamblados);
            this.pnlEnsamblados.Location = new System.Drawing.Point(475, 357);
            this.pnlEnsamblados.Name = "pnlEnsamblados";
            this.pnlEnsamblados.Size = new System.Drawing.Size(277, 316);
            this.pnlEnsamblados.TabIndex = 1;
            // 
            // btnGuardarXml
            // 
            this.btnGuardarXml.Location = new System.Drawing.Point(13, 286);
            this.btnGuardarXml.Name = "btnGuardarXml";
            this.btnGuardarXml.Size = new System.Drawing.Size(160, 23);
            this.btnGuardarXml.TabIndex = 8;
            this.btnGuardarXml.Text = "Guardar ensamblados Xml";
            this.btnGuardarXml.UseVisualStyleBackColor = true;
            this.btnGuardarXml.Click += new System.EventHandler(this.btnGuardarXml_Click);
            // 
            // btnGuardarTxt
            // 
            this.btnGuardarTxt.Location = new System.Drawing.Point(13, 257);
            this.btnGuardarTxt.Name = "btnGuardarTxt";
            this.btnGuardarTxt.Size = new System.Drawing.Size(160, 23);
            this.btnGuardarTxt.TabIndex = 7;
            this.btnGuardarTxt.Text = "Guardar ensamblados Txt";
            this.btnGuardarTxt.UseVisualStyleBackColor = true;
            this.btnGuardarTxt.Click += new System.EventHandler(this.btnGuardarTxt_Click);
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(20, 241);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(46, 13);
            this.lblTamanio.TabIndex = 4;
            this.lblTamanio.Text = "Tamaño";
            // 
            // rtbListaEnsamblados
            // 
            this.rtbListaEnsamblados.Location = new System.Drawing.Point(23, 43);
            this.rtbListaEnsamblados.Name = "rtbListaEnsamblados";
            this.rtbListaEnsamblados.Size = new System.Drawing.Size(160, 190);
            this.rtbListaEnsamblados.TabIndex = 3;
            this.rtbListaEnsamblados.Text = "";
            // 
            // lblListaEnsamblados
            // 
            this.lblListaEnsamblados.AutoSize = true;
            this.lblListaEnsamblados.Location = new System.Drawing.Point(20, 15);
            this.lblListaEnsamblados.Name = "lblListaEnsamblados";
            this.lblListaEnsamblados.Size = new System.Drawing.Size(97, 13);
            this.lblListaEnsamblados.TabIndex = 2;
            this.lblListaEnsamblados.Text = "Lista ensamblados:";
            // 
            // pnlListaEnsamblados
            // 
            this.pnlListaEnsamblados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlListaEnsamblados.Controls.Add(this.label1);
            this.pnlListaEnsamblados.Controls.Add(this.lsbEnsamblados);
            this.pnlListaEnsamblados.Controls.Add(this.btnHacerTest);
            this.pnlListaEnsamblados.Controls.Add(this.lblEnsamblados);
            this.pnlListaEnsamblados.Location = new System.Drawing.Point(21, 357);
            this.pnlListaEnsamblados.Name = "pnlListaEnsamblados";
            this.pnlListaEnsamblados.Size = new System.Drawing.Size(379, 318);
            this.pnlListaEnsamblados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00:00";
            // 
            // lsbEnsamblados
            // 
            this.lsbEnsamblados.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lsbEnsamblados.FormattingEnabled = true;
            this.lsbEnsamblados.Location = new System.Drawing.Point(17, 60);
            this.lsbEnsamblados.Name = "lsbEnsamblados";
            this.lsbEnsamblados.Size = new System.Drawing.Size(273, 238);
            this.lsbEnsamblados.TabIndex = 8;
            // 
            // btnHacerTest
            // 
            this.btnHacerTest.Location = new System.Drawing.Point(306, 126);
            this.btnHacerTest.Name = "btnHacerTest";
            this.btnHacerTest.Size = new System.Drawing.Size(59, 93);
            this.btnHacerTest.TabIndex = 7;
            this.btnHacerTest.Text = "Hacer Test";
            this.btnHacerTest.UseVisualStyleBackColor = true;
            this.btnHacerTest.Click += new System.EventHandler(this.btnHacerTest_Click);
            // 
            // lblEnsamblados
            // 
            this.lblEnsamblados.AutoSize = true;
            this.lblEnsamblados.Location = new System.Drawing.Point(21, 32);
            this.lblEnsamblados.Name = "lblEnsamblados";
            this.lblEnsamblados.Size = new System.Drawing.Size(76, 13);
            this.lblEnsamblados.TabIndex = 1;
            this.lblEnsamblados.Text = "Ensamblados: ";
            // 
            // pnlAReparar
            // 
            this.pnlAReparar.BackColor = System.Drawing.Color.LightCyan;
            this.pnlAReparar.Controls.Add(this.lsbAReparar);
            this.pnlAReparar.Controls.Add(this.lblTamanioAReparar);
            this.pnlAReparar.Controls.Add(this.btnReparar);
            this.pnlAReparar.Controls.Add(this.lblAReparar);
            this.pnlAReparar.Location = new System.Drawing.Point(1034, 357);
            this.pnlAReparar.Name = "pnlAReparar";
            this.pnlAReparar.Size = new System.Drawing.Size(239, 316);
            this.pnlAReparar.TabIndex = 2;
            // 
            // lsbAReparar
            // 
            this.lsbAReparar.FormattingEnabled = true;
            this.lsbAReparar.Location = new System.Drawing.Point(11, 43);
            this.lsbAReparar.Name = "lsbAReparar";
            this.lsbAReparar.Size = new System.Drawing.Size(172, 186);
            this.lsbAReparar.TabIndex = 11;
            // 
            // lblTamanioAReparar
            // 
            this.lblTamanioAReparar.AutoSize = true;
            this.lblTamanioAReparar.Location = new System.Drawing.Point(8, 241);
            this.lblTamanioAReparar.Name = "lblTamanioAReparar";
            this.lblTamanioAReparar.Size = new System.Drawing.Size(46, 13);
            this.lblTamanioAReparar.TabIndex = 10;
            this.lblTamanioAReparar.Text = "Tamaño";
            // 
            // btnReparar
            // 
            this.btnReparar.Location = new System.Drawing.Point(11, 270);
            this.btnReparar.Name = "btnReparar";
            this.btnReparar.Size = new System.Drawing.Size(160, 23);
            this.btnReparar.TabIndex = 9;
            this.btnReparar.Text = "Reparar";
            this.btnReparar.UseVisualStyleBackColor = true;
            this.btnReparar.Click += new System.EventHandler(this.btnReparar_Click);
            // 
            // lblAReparar
            // 
            this.lblAReparar.AutoSize = true;
            this.lblAReparar.Location = new System.Drawing.Point(18, 15);
            this.lblAReparar.Name = "lblAReparar";
            this.lblAReparar.Size = new System.Drawing.Size(80, 13);
            this.lblAReparar.TabIndex = 3;
            this.lblAReparar.Text = "Lista A Reparar";
            // 
            // pnlArchivos
            // 
            this.pnlArchivos.BackColor = System.Drawing.Color.LightCyan;
            this.pnlArchivos.Controls.Add(this.btnLeerTxt);
            this.pnlArchivos.Controls.Add(this.btnLeerXML);
            this.pnlArchivos.Controls.Add(this.rtbArchivos);
            this.pnlArchivos.Controls.Add(this.lblArchivos);
            this.pnlArchivos.Location = new System.Drawing.Point(1034, 12);
            this.pnlArchivos.Name = "pnlArchivos";
            this.pnlArchivos.Size = new System.Drawing.Size(239, 316);
            this.pnlArchivos.TabIndex = 3;
            // 
            // btnLeerTxt
            // 
            this.btnLeerTxt.Location = new System.Drawing.Point(11, 257);
            this.btnLeerTxt.Name = "btnLeerTxt";
            this.btnLeerTxt.Size = new System.Drawing.Size(160, 23);
            this.btnLeerTxt.TabIndex = 9;
            this.btnLeerTxt.Text = "Leer TXT";
            this.btnLeerTxt.UseVisualStyleBackColor = true;
            this.btnLeerTxt.Click += new System.EventHandler(this.btnLeerTxt_Click);
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.Location = new System.Drawing.Point(11, 286);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(160, 23);
            this.btnLeerXML.TabIndex = 8;
            this.btnLeerXML.Text = "Leer XML";
            this.btnLeerXML.UseVisualStyleBackColor = true;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // rtbArchivos
            // 
            this.rtbArchivos.Location = new System.Drawing.Point(23, 43);
            this.rtbArchivos.Name = "rtbArchivos";
            this.rtbArchivos.Size = new System.Drawing.Size(160, 190);
            this.rtbArchivos.TabIndex = 4;
            this.rtbArchivos.Text = "";
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Location = new System.Drawing.Point(18, 15);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(136, 13);
            this.lblArchivos.TabIndex = 3;
            this.lblArchivos.Text = "Leer archivos ensamblados";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 687);
            this.Controls.Add(this.pnlArchivos);
            this.Controls.Add(this.pnlAReparar);
            this.Controls.Add(this.pnlEnsamblados);
            this.Controls.Add(this.pnlListaEnsamblados);
            this.Controls.Add(this.pnlOk);
            this.Controls.Add(this.pnlEnsamble);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mendoza.Maximiliano.2D";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.pnlEnsamble.ResumeLayout(false);
            this.pnlEnsamble.PerformLayout();
            this.pnlTipos.ResumeLayout(false);
            this.pnlTipos.PerformLayout();
            this.pnlOk.ResumeLayout(false);
            this.pnlOk.PerformLayout();
            this.pnlEnsamblados.ResumeLayout(false);
            this.pnlEnsamblados.PerformLayout();
            this.pnlListaEnsamblados.ResumeLayout(false);
            this.pnlListaEnsamblados.PerformLayout();
            this.pnlAReparar.ResumeLayout(false);
            this.pnlAReparar.PerformLayout();
            this.pnlArchivos.ResumeLayout(false);
            this.pnlArchivos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEnsamble;
        private System.Windows.Forms.ComboBox cmbPlaqueta;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.ComboBox cmbBateria;
        private System.Windows.Forms.ComboBox cmbCarcaza;
        private System.Windows.Forms.Button btnEnsamblar;
        private System.Windows.Forms.Panel pnlTipos;
        private System.Windows.Forms.RadioButton rbtSamsumg;
        private System.Windows.Forms.RadioButton rbtNokia;
        private System.Windows.Forms.RadioButton rbtHuawei;
        private System.Windows.Forms.RadioButton rbtMotorola;
        private System.Windows.Forms.RadioButton rbtAlcatel;
        private System.Windows.Forms.Button btbAgregar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblplaqueta;
        private System.Windows.Forms.Label lblCamara;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblCarcaza;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlOk;
        private System.Windows.Forms.Panel pnlEnsamblados;
        private System.Windows.Forms.Panel pnlListaEnsamblados;
        private System.Windows.Forms.Button btnHacerTest;
        private System.Windows.Forms.Label lblEnsamblados;
        private System.Windows.Forms.Button btnGuardarXml;
        private System.Windows.Forms.Button btnGuardarTxt;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.RichTextBox rtbListaEnsamblados;
        private System.Windows.Forms.Label lblListaEnsamblados;
        private System.Windows.Forms.Label lblTamanioOk;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.RichTextBox rtbListaOk;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Panel pnlAReparar;
        private System.Windows.Forms.Label lblTamanioAReparar;
        private System.Windows.Forms.Button btnReparar;
        private System.Windows.Forms.Label lblAReparar;
        private System.Windows.Forms.ListBox lsbEnsamblados;
        private System.Windows.Forms.ListBox lsbAReparar;
        private System.Windows.Forms.Panel pnlArchivos;
        private System.Windows.Forms.Button btnLeerTxt;
        private System.Windows.Forms.Button btnLeerXML;
        private System.Windows.Forms.RichTextBox rtbArchivos;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

