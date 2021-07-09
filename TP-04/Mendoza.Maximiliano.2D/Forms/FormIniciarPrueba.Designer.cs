
namespace Forms
{
    partial class FormIniciarPrueba
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
            this.components = new System.ComponentModel.Container();
            this.lsbEnsamblados = new System.Windows.Forms.ListBox();
            this.btnHacerTest = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pgbBarra = new System.Windows.Forms.ProgressBar();
            this.lblProceso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbEnsamblados
            // 
            this.lsbEnsamblados.FormattingEnabled = true;
            this.lsbEnsamblados.Location = new System.Drawing.Point(154, 41);
            this.lsbEnsamblados.Name = "lsbEnsamblados";
            this.lsbEnsamblados.Size = new System.Drawing.Size(288, 355);
            this.lsbEnsamblados.TabIndex = 0;
            // 
            // btnHacerTest
            // 
            this.btnHacerTest.Location = new System.Drawing.Point(465, 179);
            this.btnHacerTest.Name = "btnHacerTest";
            this.btnHacerTest.Size = new System.Drawing.Size(86, 65);
            this.btnHacerTest.TabIndex = 1;
            this.btnHacerTest.Text = "Hacer test";
            this.btnHacerTest.UseVisualStyleBackColor = true;
            this.btnHacerTest.Click += new System.EventHandler(this.btnHacerTest_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgbBarra
            // 
            this.pgbBarra.Location = new System.Drawing.Point(465, 105);
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(226, 43);
            this.pgbBarra.Step = 2;
            this.pgbBarra.TabIndex = 2;
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(462, 89);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(73, 13);
            this.lblProceso.TabIndex = 3;
            this.lblProceso.Text = "Procesando...";
            // 
            // FormIniciarPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.pgbBarra);
            this.Controls.Add(this.btnHacerTest);
            this.Controls.Add(this.lsbEnsamblados);
            this.Name = "FormIniciarPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIniciarPrueba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIniciarPrueba_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbEnsamblados;
        private System.Windows.Forms.Button btnHacerTest;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.Label lblProceso;
    }
}