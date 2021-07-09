
namespace Forms
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbArmadoExterno = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnGuardarBaseDeDatos = new System.Windows.Forms.Button();
            this.btnGuardarEnDepositoEnsamblados = new System.Windows.Forms.Button();
            this.btnEliminarDeBaseDeDatos = new System.Windows.Forms.Button();
            this.lblEnsambladosExterno = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCarcaza = new System.Windows.Forms.Label();
            this.lblBateria = new System.Windows.Forms.Label();
            this.lblCamara = new System.Windows.Forms.Label();
            this.lblPlaqueta = new System.Windows.Forms.Label();
            this.cmbCarcaza = new System.Windows.Forms.ComboBox();
            this.cmbBateria = new System.Windows.Forms.ComboBox();
            this.cmbPlaqueta = new System.Windows.Forms.ComboBox();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregarCodigo = new System.Windows.Forms.Button();
            this.pnlTipos = new System.Windows.Forms.Panel();
            this.rbtMotorola = new System.Windows.Forms.RadioButton();
            this.rbtSamsumg = new System.Windows.Forms.RadioButton();
            this.rbtHuawei = new System.Windows.Forms.RadioButton();
            this.rbtNokia = new System.Windows.Forms.RadioButton();
            this.rbtAlcatel = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlTipos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbArmadoExterno
            // 
            this.lsbArmadoExterno.FormattingEnabled = true;
            this.lsbArmadoExterno.Location = new System.Drawing.Point(378, 56);
            this.lsbArmadoExterno.Name = "lsbArmadoExterno";
            this.lsbArmadoExterno.Size = new System.Drawing.Size(230, 225);
            this.lsbArmadoExterno.TabIndex = 0;
            this.lsbArmadoExterno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbArmadoExterno_MouseDoubleClick);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(378, 288);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(94, 85);
            this.btn.TabIndex = 1;
            this.btn.Text = "Cargar Productos desde BD";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGuardarBaseDeDatos
            // 
            this.btnGuardarBaseDeDatos.Location = new System.Drawing.Point(28, 341);
            this.btnGuardarBaseDeDatos.Name = "btnGuardarBaseDeDatos";
            this.btnGuardarBaseDeDatos.Size = new System.Drawing.Size(112, 40);
            this.btnGuardarBaseDeDatos.TabIndex = 2;
            this.btnGuardarBaseDeDatos.Text = "Guardar en base de datos";
            this.btnGuardarBaseDeDatos.UseVisualStyleBackColor = true;
            this.btnGuardarBaseDeDatos.Click += new System.EventHandler(this.btnGuardarBaseDeDatos_Click);
            // 
            // btnGuardarEnDepositoEnsamblados
            // 
            this.btnGuardarEnDepositoEnsamblados.Location = new System.Drawing.Point(494, 333);
            this.btnGuardarEnDepositoEnsamblados.Name = "btnGuardarEnDepositoEnsamblados";
            this.btnGuardarEnDepositoEnsamblados.Size = new System.Drawing.Size(114, 40);
            this.btnGuardarEnDepositoEnsamblados.TabIndex = 3;
            this.btnGuardarEnDepositoEnsamblados.Text = "Guardar en Deposito Ensamblados";
            this.btnGuardarEnDepositoEnsamblados.UseVisualStyleBackColor = true;
            this.btnGuardarEnDepositoEnsamblados.Click += new System.EventHandler(this.btnGuardarEnDepositoEnsamblados_Click);
            // 
            // btnEliminarDeBaseDeDatos
            // 
            this.btnEliminarDeBaseDeDatos.Location = new System.Drawing.Point(496, 287);
            this.btnEliminarDeBaseDeDatos.Name = "btnEliminarDeBaseDeDatos";
            this.btnEliminarDeBaseDeDatos.Size = new System.Drawing.Size(112, 40);
            this.btnEliminarDeBaseDeDatos.TabIndex = 4;
            this.btnEliminarDeBaseDeDatos.Text = "Eliminar de base de datos";
            this.btnEliminarDeBaseDeDatos.UseVisualStyleBackColor = true;
            this.btnEliminarDeBaseDeDatos.Click += new System.EventHandler(this.btnEliminarDeBaseDeDatos_Click);
            // 
            // lblEnsambladosExterno
            // 
            this.lblEnsambladosExterno.AutoSize = true;
            this.lblEnsambladosExterno.Location = new System.Drawing.Point(375, 24);
            this.lblEnsambladosExterno.Name = "lblEnsambladosExterno";
            this.lblEnsambladosExterno.Size = new System.Drawing.Size(146, 13);
            this.lblEnsambladosExterno.TabIndex = 5;
            this.lblEnsambladosExterno.Text = "Productos armados de afuera";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Codigo de barras";
            // 
            // lblCarcaza
            // 
            this.lblCarcaza.AutoSize = true;
            this.lblCarcaza.Location = new System.Drawing.Point(25, 59);
            this.lblCarcaza.Name = "lblCarcaza";
            this.lblCarcaza.Size = new System.Drawing.Size(46, 13);
            this.lblCarcaza.TabIndex = 7;
            this.lblCarcaza.Text = "Carcaza";
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.Location = new System.Drawing.Point(25, 105);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(40, 13);
            this.lblBateria.TabIndex = 8;
            this.lblBateria.Text = "Bateria";
            // 
            // lblCamara
            // 
            this.lblCamara.AutoSize = true;
            this.lblCamara.Location = new System.Drawing.Point(25, 151);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(43, 13);
            this.lblCamara.TabIndex = 9;
            this.lblCamara.Text = "Camara";
            // 
            // lblPlaqueta
            // 
            this.lblPlaqueta.AutoSize = true;
            this.lblPlaqueta.Location = new System.Drawing.Point(25, 189);
            this.lblPlaqueta.Name = "lblPlaqueta";
            this.lblPlaqueta.Size = new System.Drawing.Size(49, 13);
            this.lblPlaqueta.TabIndex = 10;
            this.lblPlaqueta.Text = "Plaqueta";
            // 
            // cmbCarcaza
            // 
            this.cmbCarcaza.FormattingEnabled = true;
            this.cmbCarcaza.Location = new System.Drawing.Point(161, 59);
            this.cmbCarcaza.Name = "cmbCarcaza";
            this.cmbCarcaza.Size = new System.Drawing.Size(121, 21);
            this.cmbCarcaza.TabIndex = 11;
            this.cmbCarcaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCarcaza_KeyPress);
            // 
            // cmbBateria
            // 
            this.cmbBateria.FormattingEnabled = true;
            this.cmbBateria.Location = new System.Drawing.Point(161, 102);
            this.cmbBateria.Name = "cmbBateria";
            this.cmbBateria.Size = new System.Drawing.Size(121, 21);
            this.cmbBateria.TabIndex = 12;
            this.cmbBateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBateria_KeyPress);
            // 
            // cmbPlaqueta
            // 
            this.cmbPlaqueta.FormattingEnabled = true;
            this.cmbPlaqueta.Location = new System.Drawing.Point(161, 181);
            this.cmbPlaqueta.Name = "cmbPlaqueta";
            this.cmbPlaqueta.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaqueta.TabIndex = 13;
            this.cmbPlaqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPlaqueta_KeyPress);
            // 
            // cmbCamara
            // 
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(161, 143);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(121, 21);
            this.cmbCamara.TabIndex = 14;
            this.cmbCamara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCamara_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(206, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 15;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregarCodigo
            // 
            this.btnAgregarCodigo.Location = new System.Drawing.Point(138, 16);
            this.btnAgregarCodigo.Name = "btnAgregarCodigo";
            this.btnAgregarCodigo.Size = new System.Drawing.Size(62, 24);
            this.btnAgregarCodigo.TabIndex = 16;
            this.btnAgregarCodigo.Text = "Agregar";
            this.btnAgregarCodigo.UseVisualStyleBackColor = true;
            this.btnAgregarCodigo.Click += new System.EventHandler(this.btnAgregarCodigo_Click);
            // 
            // pnlTipos
            // 
            this.pnlTipos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTipos.Controls.Add(this.rbtMotorola);
            this.pnlTipos.Controls.Add(this.rbtSamsumg);
            this.pnlTipos.Controls.Add(this.rbtHuawei);
            this.pnlTipos.Controls.Add(this.rbtNokia);
            this.pnlTipos.Controls.Add(this.rbtAlcatel);
            this.pnlTipos.Location = new System.Drawing.Point(28, 223);
            this.pnlTipos.Name = "pnlTipos";
            this.pnlTipos.Size = new System.Drawing.Size(221, 100);
            this.pnlTipos.TabIndex = 17;
            // 
            // rbtMotorola
            // 
            this.rbtMotorola.AutoSize = true;
            this.rbtMotorola.Location = new System.Drawing.Point(21, 64);
            this.rbtMotorola.Name = "rbtMotorola";
            this.rbtMotorola.Size = new System.Drawing.Size(66, 17);
            this.rbtMotorola.TabIndex = 22;
            this.rbtMotorola.TabStop = true;
            this.rbtMotorola.Text = "Motorola";
            this.rbtMotorola.UseVisualStyleBackColor = true;
            // 
            // rbtSamsumg
            // 
            this.rbtSamsumg.AutoSize = true;
            this.rbtSamsumg.Location = new System.Drawing.Point(133, 64);
            this.rbtSamsumg.Name = "rbtSamsumg";
            this.rbtSamsumg.Size = new System.Drawing.Size(71, 17);
            this.rbtSamsumg.TabIndex = 21;
            this.rbtSamsumg.TabStop = true;
            this.rbtSamsumg.Text = "Samsumg";
            this.rbtSamsumg.UseVisualStyleBackColor = true;
            // 
            // rbtHuawei
            // 
            this.rbtHuawei.AutoSize = true;
            this.rbtHuawei.Location = new System.Drawing.Point(143, 18);
            this.rbtHuawei.Name = "rbtHuawei";
            this.rbtHuawei.Size = new System.Drawing.Size(61, 17);
            this.rbtHuawei.TabIndex = 20;
            this.rbtHuawei.TabStop = true;
            this.rbtHuawei.Text = "Huawei";
            this.rbtHuawei.UseVisualStyleBackColor = true;
            // 
            // rbtNokia
            // 
            this.rbtNokia.AutoSize = true;
            this.rbtNokia.Location = new System.Drawing.Point(87, 41);
            this.rbtNokia.Name = "rbtNokia";
            this.rbtNokia.Size = new System.Drawing.Size(53, 17);
            this.rbtNokia.TabIndex = 19;
            this.rbtNokia.TabStop = true;
            this.rbtNokia.Text = "Nokia";
            this.rbtNokia.UseVisualStyleBackColor = true;
            // 
            // rbtAlcatel
            // 
            this.rbtAlcatel.AutoSize = true;
            this.rbtAlcatel.Location = new System.Drawing.Point(16, 18);
            this.rbtAlcatel.Name = "rbtAlcatel";
            this.rbtAlcatel.Size = new System.Drawing.Size(57, 17);
            this.rbtAlcatel.TabIndex = 18;
            this.rbtAlcatel.TabStop = true;
            this.rbtAlcatel.Text = "Alcatel";
            this.rbtAlcatel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.pnlTipos);
            this.panel1.Controls.Add(this.btnGuardarBaseDeDatos);
            this.panel1.Controls.Add(this.btnAgregarCodigo);
            this.panel1.Controls.Add(this.lblCarcaza);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblBateria);
            this.panel1.Controls.Add(this.cmbCamara);
            this.panel1.Controls.Add(this.lblCamara);
            this.panel1.Controls.Add(this.cmbPlaqueta);
            this.panel1.Controls.Add(this.lblPlaqueta);
            this.panel1.Controls.Add(this.cmbBateria);
            this.panel1.Controls.Add(this.cmbCarcaza);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 398);
            this.panel1.TabIndex = 18;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(615, 58);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(173, 168);
            this.rtbInfo.TabIndex = 19;
            this.rtbInfo.Text = "";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(626, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(143, 13);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "Info (doble click en el listbox)";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEnsambladosExterno);
            this.Controls.Add(this.btnEliminarDeBaseDeDatos);
            this.Controls.Add(this.btnGuardarEnDepositoEnsamblados);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lsbArmadoExterno);
            this.Name = "FormSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSQL";
            this.Load += new System.EventHandler(this.FormSQL_Load);
            this.pnlTipos.ResumeLayout(false);
            this.pnlTipos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbArmadoExterno;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnGuardarBaseDeDatos;
        private System.Windows.Forms.Button btnGuardarEnDepositoEnsamblados;
        private System.Windows.Forms.Button btnEliminarDeBaseDeDatos;
        private System.Windows.Forms.Label lblEnsambladosExterno;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCarcaza;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblCamara;
        private System.Windows.Forms.Label lblPlaqueta;
        private System.Windows.Forms.ComboBox cmbCarcaza;
        private System.Windows.Forms.ComboBox cmbBateria;
        private System.Windows.Forms.ComboBox cmbPlaqueta;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregarCodigo;
        private System.Windows.Forms.Panel pnlTipos;
        private System.Windows.Forms.RadioButton rbtMotorola;
        private System.Windows.Forms.RadioButton rbtSamsumg;
        private System.Windows.Forms.RadioButton rbtHuawei;
        private System.Windows.Forms.RadioButton rbtNokia;
        private System.Windows.Forms.RadioButton rbtAlcatel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label lblInfo;
    }
}