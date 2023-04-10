namespace App_Reutilizacion
{
    partial class Frm1
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
            this.btnWindowsMedia = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.lblAPP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWindowsMedia
            // 
            this.btnWindowsMedia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWindowsMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWindowsMedia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWindowsMedia.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowsMedia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWindowsMedia.Location = new System.Drawing.Point(132, 77);
            this.btnWindowsMedia.Name = "btnWindowsMedia";
            this.btnWindowsMedia.Size = new System.Drawing.Size(102, 43);
            this.btnWindowsMedia.TabIndex = 0;
            this.btnWindowsMedia.Text = "Windows Media Player";
            this.btnWindowsMedia.UseVisualStyleBackColor = false;
            this.btnWindowsMedia.Click += new System.EventHandler(this.btnWindowsMedia_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDF.Location = new System.Drawing.Point(132, 144);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(102, 25);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "Lector PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnNavegador
            // 
            this.btnNavegador.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNavegador.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavegador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNavegador.Location = new System.Drawing.Point(132, 195);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(102, 48);
            this.btnNavegador.TabIndex = 2;
            this.btnNavegador.Text = "Navegador WEB";
            this.btnNavegador.UseVisualStyleBackColor = false;
            // 
            // lblAPP
            // 
            this.lblAPP.AutoSize = true;
            this.lblAPP.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPP.Location = new System.Drawing.Point(12, 35);
            this.lblAPP.Name = "lblAPP";
            this.lblAPP.Size = new System.Drawing.Size(332, 23);
            this.lblAPP.TabIndex = 3;
            this.lblAPP.Text = "Elija la aplicacion que requiere utilizar";
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(360, 280);
            this.Controls.Add(this.lblAPP);
            this.Controls.Add(this.btnNavegador);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnWindowsMedia);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Frm1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWindowsMedia;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnNavegador;
        private System.Windows.Forms.Label lblAPP;
    }
}

