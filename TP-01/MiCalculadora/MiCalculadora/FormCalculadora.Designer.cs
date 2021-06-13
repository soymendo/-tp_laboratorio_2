namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.contextMenuTexBox1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colocarNumeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.contextMenuTextBox2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colocarNumeroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonConvertirABinario = new System.Windows.Forms.Button();
            this.buttonConvertirADecimal = new System.Windows.Forms.Button();
            this.comboBoxOperaciones = new System.Windows.Forms.ComboBox();
            this.contextMenuTexBox1.SuspendLayout();
            this.contextMenuTextBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(646, 58);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(94, 24);
            this.labelResultado.TabIndex = 0;
            this.labelResultado.Text = "Resultado";
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.ContextMenuStrip = this.contextMenuTexBox1;
            this.textBoxNumero1.Location = new System.Drawing.Point(125, 125);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero1.TabIndex = 1;
            this.textBoxNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero1_KeyPress);
            // 
            // contextMenuTexBox1
            // 
            this.contextMenuTexBox1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem,
            this.colocarNumeroToolStripMenuItem});
            this.contextMenuTexBox1.Name = "contextMenuTexBox1";
            this.contextMenuTexBox1.Size = new System.Drawing.Size(161, 48);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // colocarNumeroToolStripMenuItem
            // 
            this.colocarNumeroToolStripMenuItem.Name = "colocarNumeroToolStripMenuItem";
            this.colocarNumeroToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colocarNumeroToolStripMenuItem.Text = "Colocar numero";
            this.colocarNumeroToolStripMenuItem.Click += new System.EventHandler(this.colocarNumeroToolStripMenuItem_Click);
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.ContextMenuStrip = this.contextMenuTextBox2;
            this.textBoxNumero2.Location = new System.Drawing.Point(606, 125);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero2.TabIndex = 2;
            this.textBoxNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero2_KeyPress);
            // 
            // contextMenuTextBox2
            // 
            this.contextMenuTextBox2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem1,
            this.colocarNumeroToolStripMenuItem1});
            this.contextMenuTextBox2.Name = "contextMenuTextBox2";
            this.contextMenuTextBox2.Size = new System.Drawing.Size(161, 48);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // colocarNumeroToolStripMenuItem1
            // 
            this.colocarNumeroToolStripMenuItem1.Name = "colocarNumeroToolStripMenuItem1";
            this.colocarNumeroToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.colocarNumeroToolStripMenuItem1.Text = "Colocar numero";
            this.colocarNumeroToolStripMenuItem1.Click += new System.EventHandler(this.colocarNumeroToolStripMenuItem1_Click);
            // 
            // buttonOperar
            // 
            this.buttonOperar.Location = new System.Drawing.Point(125, 207);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(168, 23);
            this.buttonOperar.TabIndex = 3;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(538, 207);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(168, 23);
            this.buttonCerrar.TabIndex = 4;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(328, 207);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(168, 23);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonConvertirABinario
            // 
            this.buttonConvertirABinario.Location = new System.Drawing.Point(125, 305);
            this.buttonConvertirABinario.Name = "buttonConvertirABinario";
            this.buttonConvertirABinario.Size = new System.Drawing.Size(265, 23);
            this.buttonConvertirABinario.TabIndex = 6;
            this.buttonConvertirABinario.Text = "Convertir a binario";
            this.buttonConvertirABinario.UseVisualStyleBackColor = true;
            this.buttonConvertirABinario.Click += new System.EventHandler(this.buttonConvertirABinario_Click);
            // 
            // buttonConvertirADecimal
            // 
            this.buttonConvertirADecimal.Location = new System.Drawing.Point(427, 305);
            this.buttonConvertirADecimal.Name = "buttonConvertirADecimal";
            this.buttonConvertirADecimal.Size = new System.Drawing.Size(265, 23);
            this.buttonConvertirADecimal.TabIndex = 7;
            this.buttonConvertirADecimal.Text = "Convertir a decimal";
            this.buttonConvertirADecimal.UseVisualStyleBackColor = true;
            this.buttonConvertirADecimal.Click += new System.EventHandler(this.buttonConvertirADecimal_Click);
            // 
            // comboBoxOperaciones
            // 
            this.comboBoxOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperaciones.FormattingEnabled = true;
            this.comboBoxOperaciones.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperaciones.Location = new System.Drawing.Point(316, 125);
            this.comboBoxOperaciones.Name = "comboBoxOperaciones";
            this.comboBoxOperaciones.Size = new System.Drawing.Size(168, 28);
            this.comboBoxOperaciones.TabIndex = 8;
            this.comboBoxOperaciones.Text = "Elija operacion";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.comboBoxOperaciones);
            this.Controls.Add(this.buttonConvertirADecimal);
            this.Controls.Add(this.buttonConvertirABinario);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.labelResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Mendoza Maximiliano del curso 2D";
            this.contextMenuTexBox1.ResumeLayout(false);
            this.contextMenuTextBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonConvertirABinario;
        private System.Windows.Forms.Button buttonConvertirADecimal;
        private System.Windows.Forms.ComboBox comboBoxOperaciones;
        private System.Windows.Forms.ContextMenuStrip contextMenuTexBox1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colocarNumeroToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuTextBox2;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colocarNumeroToolStripMenuItem1;
    }
}

