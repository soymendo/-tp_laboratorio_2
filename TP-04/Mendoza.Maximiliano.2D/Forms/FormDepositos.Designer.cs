
namespace Forms
{
    partial class FormDepositos
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
            this.rtbListaEnsamblados = new System.Windows.Forms.RichTextBox();
            this.rtbListaOk = new System.Windows.Forms.RichTextBox();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.lblTamanioOk = new System.Windows.Forms.Label();
            this.lblTamanioAReparar = new System.Windows.Forms.Label();
            this.lblListaEnsamblados = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.lblAReparar = new System.Windows.Forms.Label();
            this.btnGuardarTxt = new System.Windows.Forms.Button();
            this.btnGuardarXml = new System.Windows.Forms.Button();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.lsbAReparar = new System.Windows.Forms.ListBox();
            this.btnReparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbListaEnsamblados
            // 
            this.rtbListaEnsamblados.Location = new System.Drawing.Point(23, 70);
            this.rtbListaEnsamblados.Name = "rtbListaEnsamblados";
            this.rtbListaEnsamblados.Size = new System.Drawing.Size(209, 280);
            this.rtbListaEnsamblados.TabIndex = 0;
            this.rtbListaEnsamblados.Text = "";
            // 
            // rtbListaOk
            // 
            this.rtbListaOk.Location = new System.Drawing.Point(280, 70);
            this.rtbListaOk.Name = "rtbListaOk";
            this.rtbListaOk.Size = new System.Drawing.Size(209, 280);
            this.rtbListaOk.TabIndex = 1;
            this.rtbListaOk.Text = "";
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(20, 370);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(46, 13);
            this.lblTamanio.TabIndex = 3;
            this.lblTamanio.Text = "Tamaño";
            // 
            // lblTamanioOk
            // 
            this.lblTamanioOk.AutoSize = true;
            this.lblTamanioOk.Location = new System.Drawing.Point(277, 370);
            this.lblTamanioOk.Name = "lblTamanioOk";
            this.lblTamanioOk.Size = new System.Drawing.Size(46, 13);
            this.lblTamanioOk.TabIndex = 4;
            this.lblTamanioOk.Text = "Tamaño";
            // 
            // lblTamanioAReparar
            // 
            this.lblTamanioAReparar.AutoSize = true;
            this.lblTamanioAReparar.Location = new System.Drawing.Point(544, 370);
            this.lblTamanioAReparar.Name = "lblTamanioAReparar";
            this.lblTamanioAReparar.Size = new System.Drawing.Size(46, 13);
            this.lblTamanioAReparar.TabIndex = 5;
            this.lblTamanioAReparar.Text = "Tamaño";
            // 
            // lblListaEnsamblados
            // 
            this.lblListaEnsamblados.AutoSize = true;
            this.lblListaEnsamblados.Location = new System.Drawing.Point(20, 43);
            this.lblListaEnsamblados.Name = "lblListaEnsamblados";
            this.lblListaEnsamblados.Size = new System.Drawing.Size(94, 13);
            this.lblListaEnsamblados.TabIndex = 6;
            this.lblListaEnsamblados.Text = "Lista ensamblados";
            // 
            // lblOk
            // 
            this.lblOk.AutoSize = true;
            this.lblOk.Location = new System.Drawing.Point(277, 43);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(46, 13);
            this.lblOk.TabIndex = 7;
            this.lblOk.Text = "Lista Ok";
            // 
            // lblAReparar
            // 
            this.lblAReparar.AutoSize = true;
            this.lblAReparar.Location = new System.Drawing.Point(544, 43);
            this.lblAReparar.Name = "lblAReparar";
            this.lblAReparar.Size = new System.Drawing.Size(80, 13);
            this.lblAReparar.TabIndex = 8;
            this.lblAReparar.Text = "Lista A Reparar";
            // 
            // btnGuardarTxt
            // 
            this.btnGuardarTxt.Location = new System.Drawing.Point(23, 386);
            this.btnGuardarTxt.Name = "btnGuardarTxt";
            this.btnGuardarTxt.Size = new System.Drawing.Size(209, 23);
            this.btnGuardarTxt.TabIndex = 9;
            this.btnGuardarTxt.Text = "Guardar ensamblados Txt";
            this.btnGuardarTxt.UseVisualStyleBackColor = true;
            this.btnGuardarTxt.Click += new System.EventHandler(this.btnGuardarTxt_Click);
            // 
            // btnGuardarXml
            // 
            this.btnGuardarXml.Location = new System.Drawing.Point(23, 415);
            this.btnGuardarXml.Name = "btnGuardarXml";
            this.btnGuardarXml.Size = new System.Drawing.Size(209, 23);
            this.btnGuardarXml.TabIndex = 10;
            this.btnGuardarXml.Text = "Guardar ensamblados Xml";
            this.btnGuardarXml.UseVisualStyleBackColor = true;
            this.btnGuardarXml.Click += new System.EventHandler(this.btnGuardarXml_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(280, 386);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(209, 23);
            this.btnTxt.TabIndex = 11;
            this.btnTxt.Text = "Guardar OK Txt";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(280, 415);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(209, 23);
            this.btnXml.TabIndex = 12;
            this.btnXml.Text = "Guardar OK XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // lsbAReparar
            // 
            this.lsbAReparar.FormattingEnabled = true;
            this.lsbAReparar.Location = new System.Drawing.Point(534, 73);
            this.lsbAReparar.Name = "lsbAReparar";
            this.lsbAReparar.Size = new System.Drawing.Size(209, 277);
            this.lsbAReparar.TabIndex = 13;
            // 
            // btnReparar
            // 
            this.btnReparar.Location = new System.Drawing.Point(534, 386);
            this.btnReparar.Name = "btnReparar";
            this.btnReparar.Size = new System.Drawing.Size(209, 23);
            this.btnReparar.TabIndex = 14;
            this.btnReparar.Text = "Reparar";
            this.btnReparar.UseVisualStyleBackColor = true;
            this.btnReparar.Click += new System.EventHandler(this.btnReparar_Click);
            // 
            // FormDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReparar);
            this.Controls.Add(this.lsbAReparar);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.btnGuardarXml);
            this.Controls.Add(this.btnGuardarTxt);
            this.Controls.Add(this.lblAReparar);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.lblListaEnsamblados);
            this.Controls.Add(this.lblTamanioAReparar);
            this.Controls.Add(this.lblTamanioOk);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.rtbListaOk);
            this.Controls.Add(this.rtbListaEnsamblados);
            this.Name = "FormDepositos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepositos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListaEnsamblados;
        private System.Windows.Forms.RichTextBox rtbListaOk;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.Label lblTamanioOk;
        private System.Windows.Forms.Label lblTamanioAReparar;
        private System.Windows.Forms.Label lblListaEnsamblados;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Label lblAReparar;
        private System.Windows.Forms.Button btnGuardarTxt;
        private System.Windows.Forms.Button btnGuardarXml;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.ListBox lsbAReparar;
        private System.Windows.Forms.Button btnReparar;
    }
}