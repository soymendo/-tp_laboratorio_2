
namespace Forms
{
    partial class FormMenu
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
            this.btnEnsamble = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnsamble
            // 
            this.btnEnsamble.Location = new System.Drawing.Point(274, 71);
            this.btnEnsamble.Name = "btnEnsamble";
            this.btnEnsamble.Size = new System.Drawing.Size(194, 38);
            this.btnEnsamble.TabIndex = 0;
            this.btnEnsamble.Text = "ENSAMBLAR";
            this.btnEnsamble.UseVisualStyleBackColor = true;
            this.btnEnsamble.Click += new System.EventHandler(this.btnEnsamble_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(274, 136);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(194, 38);
            this.btnPrueba.TabIndex = 1;
            this.btnPrueba.Text = "INICIAR PRUEBA DE CALIDAD";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.Location = new System.Drawing.Point(274, 203);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(194, 38);
            this.btnDepositos.TabIndex = 3;
            this.btnDepositos.Text = "DEPOSITOS";
            this.btnDepositos.UseVisualStyleBackColor = true;
            this.btnDepositos.Click += new System.EventHandler(this.btnDepositos_Click);
            // 
            // btnArchivos
            // 
            this.btnArchivos.Location = new System.Drawing.Point(274, 274);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(194, 38);
            this.btnArchivos.TabIndex = 4;
            this.btnArchivos.Text = "ARCHIVOS";
            this.btnArchivos.UseVisualStyleBackColor = true;
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(274, 335);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(194, 38);
            this.btnSQL.TabIndex = 5;
            this.btnSQL.Text = "SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.btnArchivos);
            this.Controls.Add(this.btnDepositos);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnEnsamble);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnsamble;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnDepositos;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.Button btnSQL;
    }
}

