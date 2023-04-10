namespace App_Reutilizacion
{
    partial class Windows_Media_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Windows_Media_Player));
            this.btnCargarvideo = new System.Windows.Forms.Button();
            this.txtBoxbuscar = new System.Windows.Forms.TextBox();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btnpausa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarvideo
            // 
            this.btnCargarvideo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCargarvideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarvideo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarvideo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargarvideo.Location = new System.Drawing.Point(292, 36);
            this.btnCargarvideo.Name = "btnCargarvideo";
            this.btnCargarvideo.Size = new System.Drawing.Size(102, 29);
            this.btnCargarvideo.TabIndex = 1;
            this.btnCargarvideo.Text = "Cargar video";
            this.btnCargarvideo.UseVisualStyleBackColor = false;
            this.btnCargarvideo.Click += new System.EventHandler(this.btnCargarVideo_Click);
            // 
            // txtBoxbuscar
            // 
            this.txtBoxbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxbuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxbuscar.Location = new System.Drawing.Point(107, 12);
            this.txtBoxbuscar.Name = "txtBoxbuscar";
            this.txtBoxbuscar.ReadOnly = true;
            this.txtBoxbuscar.Size = new System.Drawing.Size(475, 20);
            this.txtBoxbuscar.TabIndex = 2;
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(38, 121);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(604, 407);
            this.axWMP.TabIndex = 0;
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btniniciar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btniniciar.Location = new System.Drawing.Point(250, 73);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(78, 31);
            this.btniniciar.TabIndex = 3;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btnpausa
            // 
            this.btnpausa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnpausa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpausa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpausa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpausa.Location = new System.Drawing.Point(362, 73);
            this.btnpausa.Name = "btnpausa";
            this.btnpausa.Size = new System.Drawing.Size(78, 31);
            this.btnpausa.TabIndex = 5;
            this.btnpausa.Text = "Pausa";
            this.btnpausa.UseVisualStyleBackColor = false;
            this.btnpausa.Click += new System.EventHandler(this.btnpausa_Click);
            // 
            // Windows_Media_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(679, 540);
            this.Controls.Add(this.btnpausa);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.txtBoxbuscar);
            this.Controls.Add(this.btnCargarvideo);
            this.Controls.Add(this.axWMP);
            this.Name = "Windows_Media_Player";
            this.Text = "Windows_Media_Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button btnCargarvideo;
        private System.Windows.Forms.TextBox txtBoxbuscar;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btnpausa;
    }
}