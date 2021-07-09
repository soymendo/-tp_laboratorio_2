
namespace Forms
{
    partial class FormEnsamblar
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
            this.btnAgregarCodigo = new System.Windows.Forms.Button();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pnlTipos = new System.Windows.Forms.Panel();
            this.rbtSamsumg = new System.Windows.Forms.RadioButton();
            this.rbtMotorola = new System.Windows.Forms.RadioButton();
            this.rbtNokia = new System.Windows.Forms.RadioButton();
            this.rbtHuawei = new System.Windows.Forms.RadioButton();
            this.rbtAlcatel = new System.Windows.Forms.RadioButton();
            this.btnEnsamblar = new System.Windows.Forms.Button();
            this.lblCarcaza = new System.Windows.Forms.Label();
            this.lblBateria = new System.Windows.Forms.Label();
            this.lblCamara = new System.Windows.Forms.Label();
            this.lblplaqueta = new System.Windows.Forms.Label();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.cmbPlaqueta = new System.Windows.Forms.ComboBox();
            this.cmbBateria = new System.Windows.Forms.ComboBox();
            this.cmbCarcaza = new System.Windows.Forms.ComboBox();
            this.pnlTipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCodigo
            // 
            this.btnAgregarCodigo.Location = new System.Drawing.Point(312, 43);
            this.btnAgregarCodigo.Name = "btnAgregarCodigo";
            this.btnAgregarCodigo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCodigo.TabIndex = 0;
            this.btnAgregarCodigo.Text = "Agregar";
            this.btnAgregarCodigo.UseVisualStyleBackColor = true;
            this.btnAgregarCodigo.Click += new System.EventHandler(this.btnAgregarCodigo_Click);
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(82, 50);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoDeBarras.TabIndex = 1;
            this.lblCodigoDeBarras.Text = "CodigoDeBarras";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(441, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTipos
            // 
            this.pnlTipos.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTipos.Controls.Add(this.rbtSamsumg);
            this.pnlTipos.Controls.Add(this.rbtMotorola);
            this.pnlTipos.Controls.Add(this.rbtNokia);
            this.pnlTipos.Controls.Add(this.rbtHuawei);
            this.pnlTipos.Controls.Add(this.rbtAlcatel);
            this.pnlTipos.Location = new System.Drawing.Point(85, 235);
            this.pnlTipos.Name = "pnlTipos";
            this.pnlTipos.Size = new System.Drawing.Size(503, 127);
            this.pnlTipos.TabIndex = 3;
            // 
            // rbtSamsumg
            // 
            this.rbtSamsumg.AutoSize = true;
            this.rbtSamsumg.Location = new System.Drawing.Point(322, 81);
            this.rbtSamsumg.Name = "rbtSamsumg";
            this.rbtSamsumg.Size = new System.Drawing.Size(71, 17);
            this.rbtSamsumg.TabIndex = 8;
            this.rbtSamsumg.TabStop = true;
            this.rbtSamsumg.Text = "Samsumg";
            this.rbtSamsumg.UseVisualStyleBackColor = true;
            // 
            // rbtMotorola
            // 
            this.rbtMotorola.AutoSize = true;
            this.rbtMotorola.Location = new System.Drawing.Point(104, 80);
            this.rbtMotorola.Name = "rbtMotorola";
            this.rbtMotorola.Size = new System.Drawing.Size(66, 17);
            this.rbtMotorola.TabIndex = 7;
            this.rbtMotorola.TabStop = true;
            this.rbtMotorola.Text = "Motorola";
            this.rbtMotorola.UseVisualStyleBackColor = true;
            // 
            // rbtNokia
            // 
            this.rbtNokia.AutoSize = true;
            this.rbtNokia.Location = new System.Drawing.Point(375, 36);
            this.rbtNokia.Name = "rbtNokia";
            this.rbtNokia.Size = new System.Drawing.Size(53, 17);
            this.rbtNokia.TabIndex = 6;
            this.rbtNokia.TabStop = true;
            this.rbtNokia.Text = "Nokia";
            this.rbtNokia.UseVisualStyleBackColor = true;
            // 
            // rbtHuawei
            // 
            this.rbtHuawei.AutoSize = true;
            this.rbtHuawei.Location = new System.Drawing.Point(209, 36);
            this.rbtHuawei.Name = "rbtHuawei";
            this.rbtHuawei.Size = new System.Drawing.Size(61, 17);
            this.rbtHuawei.TabIndex = 5;
            this.rbtHuawei.TabStop = true;
            this.rbtHuawei.Text = "Huawei";
            this.rbtHuawei.UseVisualStyleBackColor = true;
            // 
            // rbtAlcatel
            // 
            this.rbtAlcatel.AutoSize = true;
            this.rbtAlcatel.Location = new System.Drawing.Point(43, 36);
            this.rbtAlcatel.Name = "rbtAlcatel";
            this.rbtAlcatel.Size = new System.Drawing.Size(57, 17);
            this.rbtAlcatel.TabIndex = 4;
            this.rbtAlcatel.TabStop = true;
            this.rbtAlcatel.Text = "Alcatel";
            this.rbtAlcatel.UseVisualStyleBackColor = true;
            // 
            // btnEnsamblar
            // 
            this.btnEnsamblar.Location = new System.Drawing.Point(43, 390);
            this.btnEnsamblar.Name = "btnEnsamblar";
            this.btnEnsamblar.Size = new System.Drawing.Size(123, 29);
            this.btnEnsamblar.TabIndex = 5;
            this.btnEnsamblar.Text = "Ensamblar";
            this.btnEnsamblar.UseVisualStyleBackColor = true;
            this.btnEnsamblar.Click += new System.EventHandler(this.btnEnsamblar_Click);
            // 
            // lblCarcaza
            // 
            this.lblCarcaza.AutoSize = true;
            this.lblCarcaza.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCarcaza.Location = new System.Drawing.Point(82, 85);
            this.lblCarcaza.Name = "lblCarcaza";
            this.lblCarcaza.Size = new System.Drawing.Size(46, 13);
            this.lblCarcaza.TabIndex = 7;
            this.lblCarcaza.Text = "Carcaza";
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBateria.Location = new System.Drawing.Point(83, 121);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(40, 13);
            this.lblBateria.TabIndex = 8;
            this.lblBateria.Text = "Bateria";
            // 
            // lblCamara
            // 
            this.lblCamara.AutoSize = true;
            this.lblCamara.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCamara.Location = new System.Drawing.Point(83, 158);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(43, 13);
            this.lblCamara.TabIndex = 9;
            this.lblCamara.Text = "Camara";
            // 
            // lblplaqueta
            // 
            this.lblplaqueta.AutoSize = true;
            this.lblplaqueta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblplaqueta.Location = new System.Drawing.Point(83, 193);
            this.lblplaqueta.Name = "lblplaqueta";
            this.lblplaqueta.Size = new System.Drawing.Size(49, 13);
            this.lblplaqueta.TabIndex = 10;
            this.lblplaqueta.Text = "Plaqueta";
            // 
            // cmbCamara
            // 
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(441, 150);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(121, 21);
            this.cmbCamara.TabIndex = 12;
            this.cmbCamara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCamara_KeyPress);
            // 
            // cmbPlaqueta
            // 
            this.cmbPlaqueta.FormattingEnabled = true;
            this.cmbPlaqueta.Location = new System.Drawing.Point(441, 189);
            this.cmbPlaqueta.Name = "cmbPlaqueta";
            this.cmbPlaqueta.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaqueta.TabIndex = 13;
            this.cmbPlaqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPlaqueta_KeyPress);
            // 
            // cmbBateria
            // 
            this.cmbBateria.FormattingEnabled = true;
            this.cmbBateria.Location = new System.Drawing.Point(441, 113);
            this.cmbBateria.Name = "cmbBateria";
            this.cmbBateria.Size = new System.Drawing.Size(121, 21);
            this.cmbBateria.TabIndex = 14;
            this.cmbBateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBateria_KeyPress);
            // 
            // cmbCarcaza
            // 
            this.cmbCarcaza.FormattingEnabled = true;
            this.cmbCarcaza.Location = new System.Drawing.Point(441, 77);
            this.cmbCarcaza.Name = "cmbCarcaza";
            this.cmbCarcaza.Size = new System.Drawing.Size(121, 21);
            this.cmbCarcaza.TabIndex = 15;
            this.cmbCarcaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCarcaza_KeyPress);
            // 
            // FormEnsamblar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCarcaza);
            this.Controls.Add(this.cmbBateria);
            this.Controls.Add(this.cmbPlaqueta);
            this.Controls.Add(this.cmbCamara);
            this.Controls.Add(this.lblplaqueta);
            this.Controls.Add(this.lblCamara);
            this.Controls.Add(this.lblBateria);
            this.Controls.Add(this.lblCarcaza);
            this.Controls.Add(this.btnEnsamblar);
            this.Controls.Add(this.pnlTipos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoDeBarras);
            this.Controls.Add(this.btnAgregarCodigo);
            this.Name = "FormEnsamblar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ensamble";
            this.Load += new System.EventHandler(this.FormEnsamblar_Load);
            this.pnlTipos.ResumeLayout(false);
            this.pnlTipos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCodigo;
        private System.Windows.Forms.Label lblCodigoDeBarras;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel pnlTipos;
        private System.Windows.Forms.RadioButton rbtSamsumg;
        private System.Windows.Forms.RadioButton rbtMotorola;
        private System.Windows.Forms.RadioButton rbtNokia;
        private System.Windows.Forms.RadioButton rbtHuawei;
        private System.Windows.Forms.RadioButton rbtAlcatel;
        private System.Windows.Forms.Button btnEnsamblar;
        private System.Windows.Forms.Label lblCarcaza;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblCamara;
        private System.Windows.Forms.Label lblplaqueta;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.ComboBox cmbPlaqueta;
        private System.Windows.Forms.ComboBox cmbBateria;
        private System.Windows.Forms.ComboBox cmbCarcaza;
    }
}