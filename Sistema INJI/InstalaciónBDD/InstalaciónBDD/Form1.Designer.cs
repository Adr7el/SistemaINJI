namespace InstalaciónBDD
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
            this.label1 = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btnIngresarLibro = new System.Windows.Forms.Button();
            this.btnIngresarPrestamo = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnGenerarDevolucion = new System.Windows.Forms.Button();
            this.btnMostrarStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Base de datos";
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(66, 63);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(75, 23);
            this.btngenerar.TabIndex = 0;
            this.btngenerar.Text = "Crear BDD";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngresarLibro
            // 
            this.btnIngresarLibro.Enabled = false;
            this.btnIngresarLibro.Location = new System.Drawing.Point(30, 121);
            this.btnIngresarLibro.Name = "btnIngresarLibro";
            this.btnIngresarLibro.Size = new System.Drawing.Size(134, 23);
            this.btnIngresarLibro.TabIndex = 1;
            this.btnIngresarLibro.Text = "Proc. Ingresar Libro";
            this.btnIngresarLibro.UseVisualStyleBackColor = true;
            this.btnIngresarLibro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIngresarPrestamo
            // 
            this.btnIngresarPrestamo.Enabled = false;
            this.btnIngresarPrestamo.Location = new System.Drawing.Point(30, 150);
            this.btnIngresarPrestamo.Name = "btnIngresarPrestamo";
            this.btnIngresarPrestamo.Size = new System.Drawing.Size(134, 23);
            this.btnIngresarPrestamo.TabIndex = 2;
            this.btnIngresarPrestamo.Text = "Proc. Ingresar Prestamo";
            this.btnIngresarPrestamo.UseVisualStyleBackColor = true;
            this.btnIngresarPrestamo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(194, 63);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 4;
            this.btnborrar.Text = "Borrar BDD";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGenerarDevolucion
            // 
            this.btnGenerarDevolucion.Enabled = false;
            this.btnGenerarDevolucion.Location = new System.Drawing.Point(182, 121);
            this.btnGenerarDevolucion.Name = "btnGenerarDevolucion";
            this.btnGenerarDevolucion.Size = new System.Drawing.Size(145, 23);
            this.btnGenerarDevolucion.TabIndex = 3;
            this.btnGenerarDevolucion.Text = "Proc. Generar Devolución";
            this.btnGenerarDevolucion.UseVisualStyleBackColor = true;
            this.btnGenerarDevolucion.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnMostrarStock
            // 
            this.btnMostrarStock.Enabled = false;
            this.btnMostrarStock.Location = new System.Drawing.Point(182, 150);
            this.btnMostrarStock.Name = "btnMostrarStock";
            this.btnMostrarStock.Size = new System.Drawing.Size(145, 23);
            this.btnMostrarStock.TabIndex = 4;
            this.btnMostrarStock.Text = "Proc.MostrarStock";
            this.btnMostrarStock.UseVisualStyleBackColor = true;
            this.btnMostrarStock.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 214);
            this.Controls.Add(this.btnMostrarStock);
            this.Controls.Add(this.btnGenerarDevolucion);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnIngresarPrestamo);
            this.Controls.Add(this.btnIngresarLibro);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Generar base de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnIngresarLibro;
        private System.Windows.Forms.Button btnIngresarPrestamo;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnGenerarDevolucion;
        private System.Windows.Forms.Button btnMostrarStock;
    }
}

