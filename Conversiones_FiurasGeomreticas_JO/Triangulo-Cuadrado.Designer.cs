namespace Conversiones_FiurasGeomreticas_JO
{
    partial class Form1
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
            this.txtbaseFigura = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENÚToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heptagonoOctagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovaloPoligonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbaseFigura
            // 
            this.txtbaseFigura.Location = new System.Drawing.Point(24, 49);
            this.txtbaseFigura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbaseFigura.Name = "txtbaseFigura";
            this.txtbaseFigura.Size = new System.Drawing.Size(148, 26);
            this.txtbaseFigura.TabIndex = 0;
            this.txtbaseFigura.Text = "Base";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(197, 49);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(148, 26);
            this.txtRadio.TabIndex = 1;
            this.txtRadio.Text = "Radio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(269, 181);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(148, 26);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.Text = "Resultado";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(368, 49);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 26);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.Text = "Altura";
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(84, 102);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(88, 24);
            this.rbTriangulo.TabIndex = 6;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbCuadrado
            // 
            this.rbCuadrado.AutoSize = true;
            this.rbCuadrado.Location = new System.Drawing.Point(269, 102);
            this.rbCuadrado.Name = "rbCuadrado";
            this.rbCuadrado.Size = new System.Drawing.Size(97, 24);
            this.rbCuadrado.TabIndex = 7;
            this.rbCuadrado.TabStop = true;
            this.rbCuadrado.Text = "Cuadrado";
            this.rbCuadrado.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENÚToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENÚToolStripMenuItem
            // 
            this.mENÚToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadradoToolStripMenuItem,
            this.circuloToolStripMenuItem,
            this.heptagonoOctagonoToolStripMenuItem,
            this.ovaloPoligonoToolStripMenuItem});
            this.mENÚToolStripMenuItem.Name = "mENÚToolStripMenuItem";
            this.mENÚToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENÚToolStripMenuItem.Text = "MENÚ";
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cuadradoToolStripMenuItem.Text = "Circulo-Rectangulo";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.circuloToolStripMenuItem.Text = "Pentágono-Hexágono";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // heptagonoOctagonoToolStripMenuItem
            // 
            this.heptagonoOctagonoToolStripMenuItem.Name = "heptagonoOctagonoToolStripMenuItem";
            this.heptagonoOctagonoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.heptagonoOctagonoToolStripMenuItem.Text = "Heptagono-Octógono";
            this.heptagonoOctagonoToolStripMenuItem.Click += new System.EventHandler(this.heptagonoOctagonoToolStripMenuItem_Click);
            // 
            // ovaloPoligonoToolStripMenuItem
            // 
            this.ovaloPoligonoToolStripMenuItem.Name = "ovaloPoligonoToolStripMenuItem";
            this.ovaloPoligonoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ovaloPoligonoToolStripMenuItem.Text = "Ovalo-Poligono";
            this.ovaloPoligonoToolStripMenuItem.Click += new System.EventHandler(this.ovaloPoligonoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 291);
            this.Controls.Add(this.rbCuadrado);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtbaseFigura);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangulo-Cuadrado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbaseFigura;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbCuadrado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENÚToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heptagonoOctagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ovaloPoligonoToolStripMenuItem;
    }
}

