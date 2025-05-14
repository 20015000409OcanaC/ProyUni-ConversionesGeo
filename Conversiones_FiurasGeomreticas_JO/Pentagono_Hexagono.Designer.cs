namespace Conversiones_FiurasGeomreticas_JO
{
    partial class Pentagono_Hexagono
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
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.rbExagono = new System.Windows.Forms.RadioButton();
            this.rbPentagono = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENÚToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloCuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciculoRectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heptagonoOctagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovaloPoligonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApotema
            // 
            this.txtApotema.Location = new System.Drawing.Point(543, 65);
            this.txtApotema.Margin = new System.Windows.Forms.Padding(8);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(220, 26);
            this.txtApotema.TabIndex = 19;
            this.txtApotema.Text = "Apotema";
            // 
            // rbExagono
            // 
            this.rbExagono.AutoSize = true;
            this.rbExagono.Location = new System.Drawing.Point(543, 134);
            this.rbExagono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbExagono.Name = "rbExagono";
            this.rbExagono.Size = new System.Drawing.Size(100, 24);
            this.rbExagono.TabIndex = 18;
            this.rbExagono.TabStop = true;
            this.rbExagono.Text = "Hexágono";
            this.rbExagono.UseVisualStyleBackColor = true;
            // 
            // rbPentagono
            // 
            this.rbPentagono.AutoSize = true;
            this.rbPentagono.Location = new System.Drawing.Point(124, 134);
            this.rbPentagono.Margin = new System.Windows.Forms.Padding(8);
            this.rbPentagono.Name = "rbPentagono";
            this.rbPentagono.Size = new System.Drawing.Size(105, 24);
            this.rbPentagono.TabIndex = 17;
            this.rbPentagono.TabStop = true;
            this.rbPentagono.Text = "Pentágono";
            this.rbPentagono.UseVisualStyleBackColor = true;
            this.rbPentagono.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(332, 235);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(328, 26);
            this.txtResultado.TabIndex = 16;
            this.txtResultado.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 82);
            this.button1.TabIndex = 15;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(276, 65);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(8);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(220, 26);
            this.txtPerimetro.TabIndex = 14;
            this.txtPerimetro.Text = "Perimetro";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(15, 65);
            this.txtLongitud.Margin = new System.Windows.Forms.Padding(8);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(220, 26);
            this.txtLongitud.TabIndex = 13;
            this.txtLongitud.Text = "Longitud";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENÚToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENÚToolStripMenuItem
            // 
            this.mENÚToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trianguloCuadradoToolStripMenuItem,
            this.ciculoRectanguloToolStripMenuItem,
            this.heptagonoOctagonoToolStripMenuItem,
            this.ovaloPoligonoToolStripMenuItem});
            this.mENÚToolStripMenuItem.Name = "mENÚToolStripMenuItem";
            this.mENÚToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENÚToolStripMenuItem.Text = "MENÚ";
            // 
            // trianguloCuadradoToolStripMenuItem
            // 
            this.trianguloCuadradoToolStripMenuItem.Name = "trianguloCuadradoToolStripMenuItem";
            this.trianguloCuadradoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.trianguloCuadradoToolStripMenuItem.Text = "Triangulo-Cuadrado";
            this.trianguloCuadradoToolStripMenuItem.Click += new System.EventHandler(this.trianguloCuadradoToolStripMenuItem_Click);
            // 
            // ciculoRectanguloToolStripMenuItem
            // 
            this.ciculoRectanguloToolStripMenuItem.Name = "ciculoRectanguloToolStripMenuItem";
            this.ciculoRectanguloToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ciculoRectanguloToolStripMenuItem.Text = "Ciculo-Rectangulo";
            this.ciculoRectanguloToolStripMenuItem.Click += new System.EventHandler(this.ciculoRectanguloToolStripMenuItem_Click);
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
            // Pentagono_Hexagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 314);
            this.Controls.Add(this.txtApotema);
            this.Controls.Add(this.rbExagono);
            this.Controls.Add(this.rbPentagono);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pentagono_Hexagono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pentagono_Hexagono";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.RadioButton rbExagono;
        private System.Windows.Forms.RadioButton rbPentagono;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENÚToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloCuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciculoRectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heptagonoOctagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ovaloPoligonoToolStripMenuItem;
    }
}