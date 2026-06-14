namespace FigurasGeometricasApp
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
            this.gpTriangulo = new System.Windows.Forms.GroupBox();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.lbAlturaTriangulo = new System.Windows.Forms.Label();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.lbBaseTriangulo = new System.Windows.Forms.Label();
            this.gpRectangulo = new System.Windows.Forms.GroupBox();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.txtAlturaRectangulo = new System.Windows.Forms.TextBox();
            this.lbAlturaRectangulo = new System.Windows.Forms.Label();
            this.txtBaseRectangulo = new System.Windows.Forms.TextBox();
            this.lbBaseRectangulo = new System.Windows.Forms.Label();
            this.gpElipse = new System.Windows.Forms.GroupBox();
            this.btnElipse = new System.Windows.Forms.Button();
            this.txtRadioMayorElipse = new System.Windows.Forms.TextBox();
            this.lbRadioMayorElipse = new System.Windows.Forms.Label();
            this.txtRadioMenorElipse = new System.Windows.Forms.TextBox();
            this.lbRadioMenorElipse = new System.Windows.Forms.Label();
            this.lbPila = new System.Windows.Forms.Label();
            this.lbMostrarPila = new System.Windows.Forms.Button();
            this.gpTriangulo.SuspendLayout();
            this.gpRectangulo.SuspendLayout();
            this.gpElipse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTriangulo
            // 
            this.gpTriangulo.Controls.Add(this.btnTriangulo);
            this.gpTriangulo.Controls.Add(this.txtAlturaTriangulo);
            this.gpTriangulo.Controls.Add(this.lbAlturaTriangulo);
            this.gpTriangulo.Controls.Add(this.txtBaseTriangulo);
            this.gpTriangulo.Controls.Add(this.lbBaseTriangulo);
            this.gpTriangulo.Location = new System.Drawing.Point(30, 35);
            this.gpTriangulo.Name = "gpTriangulo";
            this.gpTriangulo.Size = new System.Drawing.Size(200, 168);
            this.gpTriangulo.TabIndex = 0;
            this.gpTriangulo.TabStop = false;
            this.gpTriangulo.Text = "Triangulo";
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(43, 128);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(113, 23);
            this.btnTriangulo.TabIndex = 6;
            this.btnTriangulo.Text = "Calcular Área";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(26, 92);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(152, 20);
            this.txtAlturaTriangulo.TabIndex = 5;
            this.txtAlturaTriangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros_KeyPress);
            // 
            // lbAlturaTriangulo
            // 
            this.lbAlturaTriangulo.AutoSize = true;
            this.lbAlturaTriangulo.Location = new System.Drawing.Point(23, 76);
            this.lbAlturaTriangulo.Name = "lbAlturaTriangulo";
            this.lbAlturaTriangulo.Size = new System.Drawing.Size(34, 13);
            this.lbAlturaTriangulo.TabIndex = 4;
            this.lbAlturaTriangulo.Text = "Altura";
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Location = new System.Drawing.Point(24, 45);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(152, 20);
            this.txtBaseTriangulo.TabIndex = 3;
            this.txtBaseTriangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros_KeyPress);
            // 
            // lbBaseTriangulo
            // 
            this.lbBaseTriangulo.AutoSize = true;
            this.lbBaseTriangulo.Location = new System.Drawing.Point(21, 29);
            this.lbBaseTriangulo.Name = "lbBaseTriangulo";
            this.lbBaseTriangulo.Size = new System.Drawing.Size(31, 13);
            this.lbBaseTriangulo.TabIndex = 2;
            this.lbBaseTriangulo.Text = "Base";
            // 
            // gpRectangulo
            // 
            this.gpRectangulo.Controls.Add(this.btnRectangulo);
            this.gpRectangulo.Controls.Add(this.txtAlturaRectangulo);
            this.gpRectangulo.Controls.Add(this.lbAlturaRectangulo);
            this.gpRectangulo.Controls.Add(this.txtBaseRectangulo);
            this.gpRectangulo.Controls.Add(this.lbBaseRectangulo);
            this.gpRectangulo.Location = new System.Drawing.Point(273, 35);
            this.gpRectangulo.Name = "gpRectangulo";
            this.gpRectangulo.Size = new System.Drawing.Size(200, 168);
            this.gpRectangulo.TabIndex = 1;
            this.gpRectangulo.TabStop = false;
            this.gpRectangulo.Text = "Rectángulo";
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(43, 128);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(113, 23);
            this.btnRectangulo.TabIndex = 6;
            this.btnRectangulo.Text = "Calcular Área";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // txtAlturaRectangulo
            // 
            this.txtAlturaRectangulo.Location = new System.Drawing.Point(26, 92);
            this.txtAlturaRectangulo.Name = "txtAlturaRectangulo";
            this.txtAlturaRectangulo.Size = new System.Drawing.Size(152, 20);
            this.txtAlturaRectangulo.TabIndex = 5;
            this.txtAlturaRectangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros_KeyPress);
            // 
            // lbAlturaRectangulo
            // 
            this.lbAlturaRectangulo.AutoSize = true;
            this.lbAlturaRectangulo.Location = new System.Drawing.Point(23, 76);
            this.lbAlturaRectangulo.Name = "lbAlturaRectangulo";
            this.lbAlturaRectangulo.Size = new System.Drawing.Size(34, 13);
            this.lbAlturaRectangulo.TabIndex = 4;
            this.lbAlturaRectangulo.Text = "Altura";
            // 
            // txtBaseRectangulo
            // 
            this.txtBaseRectangulo.Location = new System.Drawing.Point(24, 45);
            this.txtBaseRectangulo.Name = "txtBaseRectangulo";
            this.txtBaseRectangulo.Size = new System.Drawing.Size(152, 20);
            this.txtBaseRectangulo.TabIndex = 3;
            this.txtBaseRectangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros_KeyPress);
            // 
            // lbBaseRectangulo
            // 
            this.lbBaseRectangulo.AutoSize = true;
            this.lbBaseRectangulo.Location = new System.Drawing.Point(21, 29);
            this.lbBaseRectangulo.Name = "lbBaseRectangulo";
            this.lbBaseRectangulo.Size = new System.Drawing.Size(31, 13);
            this.lbBaseRectangulo.TabIndex = 2;
            this.lbBaseRectangulo.Text = "Base";
            // 
            // gpElipse
            // 
            this.gpElipse.Controls.Add(this.btnElipse);
            this.gpElipse.Controls.Add(this.txtRadioMayorElipse);
            this.gpElipse.Controls.Add(this.lbRadioMayorElipse);
            this.gpElipse.Controls.Add(this.txtRadioMenorElipse);
            this.gpElipse.Controls.Add(this.lbRadioMenorElipse);
            this.gpElipse.Location = new System.Drawing.Point(509, 35);
            this.gpElipse.Name = "gpElipse";
            this.gpElipse.Size = new System.Drawing.Size(200, 168);
            this.gpElipse.TabIndex = 2;
            this.gpElipse.TabStop = false;
            this.gpElipse.Text = "Elipse";
            // 
            // btnElipse
            // 
            this.btnElipse.Location = new System.Drawing.Point(43, 128);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(113, 23);
            this.btnElipse.TabIndex = 6;
            this.btnElipse.Text = "Calcular Área";
            this.btnElipse.UseVisualStyleBackColor = true;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // txtRadioMayorElipse
            // 
            this.txtRadioMayorElipse.Location = new System.Drawing.Point(26, 92);
            this.txtRadioMayorElipse.Name = "txtRadioMayorElipse";
            this.txtRadioMayorElipse.Size = new System.Drawing.Size(152, 20);
            this.txtRadioMayorElipse.TabIndex = 5;
            this.txtRadioMayorElipse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros_KeyPress);
            // 
            // lbRadioMayorElipse
            // 
            this.lbRadioMayorElipse.AutoSize = true;
            this.lbRadioMayorElipse.Location = new System.Drawing.Point(23, 76);
            this.lbRadioMayorElipse.Name = "lbRadioMayorElipse";
            this.lbRadioMayorElipse.Size = new System.Drawing.Size(66, 13);
            this.lbRadioMayorElipse.TabIndex = 4;
            this.lbRadioMayorElipse.Text = "Radio mayor";
            // 
            // txtRadioMenorElipse
            // 
            this.txtRadioMenorElipse.Location = new System.Drawing.Point(24, 45);
            this.txtRadioMenorElipse.Name = "txtRadioMenorElipse";
            this.txtRadioMenorElipse.Size = new System.Drawing.Size(152, 20);
            this.txtRadioMenorElipse.TabIndex = 3;
            this.txtRadioMenorElipse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros_KeyPress);
            // 
            // lbRadioMenorElipse
            // 
            this.lbRadioMenorElipse.AutoSize = true;
            this.lbRadioMenorElipse.Location = new System.Drawing.Point(21, 29);
            this.lbRadioMenorElipse.Name = "lbRadioMenorElipse";
            this.lbRadioMenorElipse.Size = new System.Drawing.Size(67, 13);
            this.lbRadioMenorElipse.TabIndex = 2;
            this.lbRadioMenorElipse.Text = "Radio menor";
            // 
            // lbPila
            // 
            this.lbPila.Location = new System.Drawing.Point(51, 261);
            this.lbPila.Name = "lbPila";
            this.lbPila.Size = new System.Drawing.Size(658, 166);
            this.lbPila.TabIndex = 3;
            // 
            // lbMostrarPila
            // 
            this.lbMostrarPila.Location = new System.Drawing.Point(316, 220);
            this.lbMostrarPila.Name = "lbMostrarPila";
            this.lbMostrarPila.Size = new System.Drawing.Size(113, 23);
            this.lbMostrarPila.TabIndex = 7;
            this.lbMostrarPila.Text = "Mostrar Pila";
            this.lbMostrarPila.UseVisualStyleBackColor = true;
            this.lbMostrarPila.Click += new System.EventHandler(this.lbMostrarPila_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.lbMostrarPila);
            this.Controls.Add(this.lbPila);
            this.Controls.Add(this.gpElipse);
            this.Controls.Add(this.gpRectangulo);
            this.Controls.Add(this.gpTriangulo);
            this.Name = "Form1";
            this.Text = "Figuras Geométricas";
            this.gpTriangulo.ResumeLayout(false);
            this.gpTriangulo.PerformLayout();
            this.gpRectangulo.ResumeLayout(false);
            this.gpRectangulo.PerformLayout();
            this.gpElipse.ResumeLayout(false);
            this.gpElipse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTriangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.TextBox txtAlturaTriangulo;
        private System.Windows.Forms.Label lbAlturaTriangulo;
        private System.Windows.Forms.TextBox txtBaseTriangulo;
        private System.Windows.Forms.Label lbBaseTriangulo;
        private System.Windows.Forms.GroupBox gpRectangulo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.TextBox txtAlturaRectangulo;
        private System.Windows.Forms.Label lbAlturaRectangulo;
        private System.Windows.Forms.TextBox txtBaseRectangulo;
        private System.Windows.Forms.Label lbBaseRectangulo;
        private System.Windows.Forms.GroupBox gpElipse;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.TextBox txtRadioMayorElipse;
        private System.Windows.Forms.Label lbRadioMayorElipse;
        private System.Windows.Forms.TextBox txtRadioMenorElipse;
        private System.Windows.Forms.Label lbRadioMenorElipse;
        private System.Windows.Forms.Label lbPila;
        private System.Windows.Forms.Button lbMostrarPila;
    }
}

