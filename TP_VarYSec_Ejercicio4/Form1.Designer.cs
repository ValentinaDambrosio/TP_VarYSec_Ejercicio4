namespace TP_VarYSec_Ejercicio4
{
    partial class fArchivo
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
            this.bCerrar = new System.Windows.Forms.Button();
            this.bGigaBytes = new System.Windows.Forms.Button();
            this.lArchivo = new System.Windows.Forms.Label();
            this.lTamaño = new System.Windows.Forms.Label();
            this.lMb = new System.Windows.Forms.Label();
            this.tArchivo = new System.Windows.Forms.TextBox();
            this.tTamaño = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(421, 235);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bGigaBytes
            // 
            this.bGigaBytes.Location = new System.Drawing.Point(306, 235);
            this.bGigaBytes.Name = "bGigaBytes";
            this.bGigaBytes.Size = new System.Drawing.Size(91, 23);
            this.bGigaBytes.TabIndex = 1;
            this.bGigaBytes.Text = "Tamaño en Gb";
            this.bGigaBytes.UseVisualStyleBackColor = true;
            this.bGigaBytes.Click += new System.EventHandler(this.bGigaBytes_Click);
            // 
            // lArchivo
            // 
            this.lArchivo.AutoSize = true;
            this.lArchivo.Location = new System.Drawing.Point(28, 43);
            this.lArchivo.Name = "lArchivo";
            this.lArchivo.Size = new System.Drawing.Size(102, 13);
            this.lArchivo.TabIndex = 2;
            this.lArchivo.Text = "Nombre del archivo:";
            // 
            // lTamaño
            // 
            this.lTamaño.AutoSize = true;
            this.lTamaño.Location = new System.Drawing.Point(81, 81);
            this.lTamaño.Name = "lTamaño";
            this.lTamaño.Size = new System.Drawing.Size(49, 13);
            this.lTamaño.TabIndex = 3;
            this.lTamaño.Text = "Tamaño:";
            // 
            // lMb
            // 
            this.lMb.AutoSize = true;
            this.lMb.Location = new System.Drawing.Point(242, 81);
            this.lMb.Name = "lMb";
            this.lMb.Size = new System.Drawing.Size(22, 13);
            this.lMb.TabIndex = 4;
            this.lMb.Text = "Mb";
            // 
            // tArchivo
            // 
            this.tArchivo.Location = new System.Drawing.Point(136, 43);
            this.tArchivo.Name = "tArchivo";
            this.tArchivo.Size = new System.Drawing.Size(100, 20);
            this.tArchivo.TabIndex = 6;
            // 
            // tTamaño
            // 
            this.tTamaño.Location = new System.Drawing.Point(136, 78);
            this.tTamaño.Name = "tTamaño";
            this.tTamaño.Size = new System.Drawing.Size(100, 20);
            this.tTamaño.TabIndex = 7;
            // 
            // fArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 297);
            this.Controls.Add(this.tTamaño);
            this.Controls.Add(this.tArchivo);
            this.Controls.Add(this.lMb);
            this.Controls.Add(this.lTamaño);
            this.Controls.Add(this.lArchivo);
            this.Controls.Add(this.bGigaBytes);
            this.Controls.Add(this.bCerrar);
            this.Name = "fArchivo";
            this.Text = "Archivo en Mb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bGigaBytes;
        private System.Windows.Forms.Label lArchivo;
        private System.Windows.Forms.Label lTamaño;
        private System.Windows.Forms.Label lMb;
        private System.Windows.Forms.TextBox tArchivo;
        private System.Windows.Forms.TextBox tTamaño;
    }
}

