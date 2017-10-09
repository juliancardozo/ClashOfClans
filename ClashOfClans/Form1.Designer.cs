namespace ClashOfClans
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
            this.btnCrearAldea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearAldea
            // 
            this.btnCrearAldea.Location = new System.Drawing.Point(221, 238);
            this.btnCrearAldea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearAldea.Name = "btnCrearAldea";
            this.btnCrearAldea.Size = new System.Drawing.Size(100, 28);
            this.btnCrearAldea.TabIndex = 0;
            this.btnCrearAldea.Text = "Crear Aldea";
            this.btnCrearAldea.UseVisualStyleBackColor = true;
            this.btnCrearAldea.Click += new System.EventHandler(this.btnCrearAldea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnCrearAldea);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAldea;
    }
}

