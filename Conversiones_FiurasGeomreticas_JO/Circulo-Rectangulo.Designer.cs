namespace Conversiones_FiurasGeomreticas_JO
{
    partial class cuadrado
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
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENÚToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloCuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonoHexagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heptagonoOctagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovaloPoligonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(12, 59);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(5);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(148, 26);
            this.txtRadio.TabIndex = 6;
            this.txtRadio.Text = "Radio";
            this.txtRadio.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(186, 59);
            this.txtBase.Margin = new System.Windows.Forms.Padding(5);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(148, 26);
            this.txtBase.TabIndex = 7;
            this.txtBase.Text = "Base";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(210, 244);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(220, 26);
            this.txtResultado.TabIndex = 9;
            this.txtResultado.Text = "Resultado";
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(85, 104);
            this.rbCirculo.Margin = new System.Windows.Forms.Padding(5);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(75, 24);
            this.rbCirculo.TabIndex = 10;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Location = new System.Drawing.Point(364, 104);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(109, 24);
            this.rbRectangulo.TabIndex = 11;
            this.rbRectangulo.TabStop = true;
            this.rbRectangulo.Text = "Rectangulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(364, 59);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(5);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(148, 26);
            this.txtAltura.TabIndex = 12;
            this.txtAltura.Text = "Altura";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENÚToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENÚToolStripMenuItem
            // 
            this.mENÚToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trianguloCuadradoToolStripMenuItem,
            this.pentagonoHexagonToolStripMenuItem,
            this.heptagonoOctagonoToolStripMenuItem,
            this.ovaloPoligonoToolStripMenuItem});
            this.mENÚToolStripMenuItem.Name = "mENÚToolStripMenuItem";
            this.mENÚToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENÚToolStripMenuItem.Text = "MENÚ";
            // 
            // trianguloCuadradoToolStripMenuItem
            // 
            this.trianguloCuadradoToolStripMenuItem.Name = "trianguloCuadradoToolStripMenuItem";
            this.trianguloCuadradoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.trianguloCuadradoToolStripMenuItem.Text = "Triangulo-Cuadrado";
            this.trianguloCuadradoToolStripMenuItem.Click += new System.EventHandler(this.trianguloCuadradoToolStripMenuItem_Click);
            // 
            // pentagonoHexagonToolStripMenuItem
            // 
            this.pentagonoHexagonToolStripMenuItem.Name = "pentagonoHexagonToolStripMenuItem";
            this.pentagonoHexagonToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pentagonoHexagonToolStripMenuItem.Text = "Pentagono-Hexagono";
            this.pentagonoHexagonToolStripMenuItem.Click += new System.EventHandler(this.pentagonoHexagonToolStripMenuItem_Click);
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
            // cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 312);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.rbRectangulo);
            this.Controls.Add(this.rbCirculo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "cuadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circulo-Rectangulo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbRectangulo;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENÚToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloCuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentagonoHexagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heptagonoOctagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ovaloPoligonoToolStripMenuItem;
    }
}