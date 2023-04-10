namespace App_Reutilizacion
{
    partial class PDF_Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_Reader));
            this.axPDF = new AxAcroPDFLib.AxAcroPDF();
            this.btnAbrirPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // axPDF
            // 
            this.axPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axPDF.Enabled = true;
            this.axPDF.Location = new System.Drawing.Point(38, 12);
            this.axPDF.Name = "axPDF";
            this.axPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPDF.OcxState")));
            this.axPDF.Size = new System.Drawing.Size(788, 445);
            this.axPDF.TabIndex = 0;
            // 
            // btnAbrirPDF
            // 
            this.btnAbrirPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirPDF.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAbrirPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirPDF.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPDF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbrirPDF.Location = new System.Drawing.Point(353, 472);
            this.btnAbrirPDF.Name = "btnAbrirPDF";
            this.btnAbrirPDF.Size = new System.Drawing.Size(166, 61);
            this.btnAbrirPDF.TabIndex = 1;
            this.btnAbrirPDF.Text = "&Abrir PDF";
            this.btnAbrirPDF.UseVisualStyleBackColor = false;
            this.btnAbrirPDF.Click += new System.EventHandler(this.btnAbrirPDF_Click);
            // 
            // PDF_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(867, 545);
            this.Controls.Add(this.btnAbrirPDF);
            this.Controls.Add(this.axPDF);
            this.Name = "PDF_Reader";
            this.Text = "PDF_Reader";
            ((System.ComponentModel.ISupportInitialize)(this.axPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axPDF;
        private System.Windows.Forms.Button btnAbrirPDF;
    }
}