
namespace WindowsFormsApp1
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.listBoxOrden = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeccionB = new System.Windows.Forms.Button();
            this.buttonSeccionC = new System.Windows.Forms.Button();
            this.buttonSeccionD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(479, 178);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(158, 39);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Nombres y Sección";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.Location = new System.Drawing.Point(64, 49);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(158, 38);
            this.buttonCargarArchivo.TabIndex = 2;
            this.buttonCargarArchivo.Text = "Cargar archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(228, 12);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(385, 123);
            this.textBoxResultado.TabIndex = 3;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(138, 179);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(158, 38);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Separar Nombres y Prom";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(42, 223);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(388, 186);
            this.listBoxResultado.TabIndex = 1;
            this.listBoxResultado.SelectedIndexChanged += new System.EventHandler(this.listBoxResultado_SelectedIndexChanged);
            // 
            // listBoxOrden
            // 
            this.listBoxOrden.FormattingEnabled = true;
            this.listBoxOrden.Location = new System.Drawing.Point(458, 223);
            this.listBoxOrden.Name = "listBoxOrden";
            this.listBoxOrden.Size = new System.Drawing.Size(388, 186);
            this.listBoxOrden.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Promedio por sección A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeccionB
            // 
            this.buttonSeccionB.Location = new System.Drawing.Point(663, 93);
            this.buttonSeccionB.Name = "buttonSeccionB";
            this.buttonSeccionB.Size = new System.Drawing.Size(158, 37);
            this.buttonSeccionB.TabIndex = 7;
            this.buttonSeccionB.Text = "Promedio por sección B";
            this.buttonSeccionB.UseVisualStyleBackColor = true;
            this.buttonSeccionB.Click += new System.EventHandler(this.buttonSeccionB_Click);
            // 
            // buttonSeccionC
            // 
            this.buttonSeccionC.Location = new System.Drawing.Point(663, 136);
            this.buttonSeccionC.Name = "buttonSeccionC";
            this.buttonSeccionC.Size = new System.Drawing.Size(158, 37);
            this.buttonSeccionC.TabIndex = 8;
            this.buttonSeccionC.Text = "Promedio por sección C";
            this.buttonSeccionC.UseVisualStyleBackColor = true;
            this.buttonSeccionC.Click += new System.EventHandler(this.buttonSeccionC_Click);
            // 
            // buttonSeccionD
            // 
            this.buttonSeccionD.Location = new System.Drawing.Point(663, 179);
            this.buttonSeccionD.Name = "buttonSeccionD";
            this.buttonSeccionD.Size = new System.Drawing.Size(158, 37);
            this.buttonSeccionD.TabIndex = 9;
            this.buttonSeccionD.Text = "Promedio por sección D";
            this.buttonSeccionD.UseVisualStyleBackColor = true;
            this.buttonSeccionD.Click += new System.EventHandler(this.buttonSeccionD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.buttonSeccionD);
            this.Controls.Add(this.buttonSeccionC);
            this.Controls.Add(this.buttonSeccionB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxOrden);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.ListBox listBoxOrden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeccionB;
        private System.Windows.Forms.Button buttonSeccionC;
        private System.Windows.Forms.Button buttonSeccionD;
    }
}

