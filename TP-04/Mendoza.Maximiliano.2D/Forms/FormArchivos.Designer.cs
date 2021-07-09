
namespace Forms
{
    partial class FormArchivos
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
            this.rtbArchivos = new System.Windows.Forms.RichTextBox();
            this.btnLeerTxt = new System.Windows.Forms.Button();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.btnLeerXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbArchivos
            // 
            this.rtbArchivos.Location = new System.Drawing.Point(273, 69);
            this.rtbArchivos.Name = "rtbArchivos";
            this.rtbArchivos.Size = new System.Drawing.Size(203, 251);
            this.rtbArchivos.TabIndex = 0;
            this.rtbArchivos.Text = "";
            // 
            // btnLeerTxt
            // 
            this.btnLeerTxt.Location = new System.Drawing.Point(273, 342);
            this.btnLeerTxt.Name = "btnLeerTxt";
            this.btnLeerTxt.Size = new System.Drawing.Size(203, 23);
            this.btnLeerTxt.TabIndex = 1;
            this.btnLeerTxt.Text = "Leer TXT";
            this.btnLeerTxt.UseVisualStyleBackColor = true;
            this.btnLeerTxt.Click += new System.EventHandler(this.btnLeerTxt_Click);
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Location = new System.Drawing.Point(270, 36);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(136, 13);
            this.lblArchivos.TabIndex = 2;
            this.lblArchivos.Text = "Leer archivos ensamblados";
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.Location = new System.Drawing.Point(273, 383);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(203, 23);
            this.btnLeerXML.TabIndex = 3;
            this.btnLeerXML.Text = "Leer XML";
            this.btnLeerXML.UseVisualStyleBackColor = true;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // FormArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeerXML);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.btnLeerTxt);
            this.Controls.Add(this.rtbArchivos);
            this.Name = "FormArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArchivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbArchivos;
        private System.Windows.Forms.Button btnLeerTxt;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Button btnLeerXML;
    }
}