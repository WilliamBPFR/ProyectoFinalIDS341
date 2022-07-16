namespace ProyectoFinalControlGastos
{
    partial class General
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
            this.GeneralTitle = new System.Windows.Forms.Label();
            this.GeneralView = new System.Windows.Forms.Button();
            this.GeneralAdd = new System.Windows.Forms.Button();
            this.GeneralSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneralTitle
            // 
            this.GeneralTitle.AutoSize = true;
            this.GeneralTitle.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.GeneralTitle.ForeColor = System.Drawing.Color.Gold;
            this.GeneralTitle.Location = new System.Drawing.Point(77, 72);
            this.GeneralTitle.Name = "GeneralTitle";
            this.GeneralTitle.Size = new System.Drawing.Size(270, 42);
            this.GeneralTitle.TabIndex = 1;
            this.GeneralTitle.Text = "Nombre de la app";
            this.GeneralTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GeneralTitle.Click += new System.EventHandler(this.GeneralTitle_Click);
            // 
            // GeneralView
            // 
            this.GeneralView.BackColor = System.Drawing.Color.Magenta;
            this.GeneralView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeneralView.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeneralView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeneralView.Image = global::ProyectoFinalControlGastos.Properties.Resources.lista_de_precios;
            this.GeneralView.Location = new System.Drawing.Point(103, 173);
            this.GeneralView.Name = "GeneralView";
            this.GeneralView.Size = new System.Drawing.Size(221, 41);
            this.GeneralView.TabIndex = 2;
            this.GeneralView.Text = "Ver Transacciones";
            this.GeneralView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GeneralView.UseVisualStyleBackColor = false;
            // 
            // GeneralAdd
            // 
            this.GeneralAdd.BackColor = System.Drawing.Color.Lime;
            this.GeneralAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeneralAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeneralAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeneralAdd.Image = global::ProyectoFinalControlGastos.Properties.Resources.anadir;
            this.GeneralAdd.Location = new System.Drawing.Point(103, 241);
            this.GeneralAdd.Name = "GeneralAdd";
            this.GeneralAdd.Size = new System.Drawing.Size(221, 38);
            this.GeneralAdd.TabIndex = 3;
            this.GeneralAdd.Text = "Añadir Transacción";
            this.GeneralAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GeneralAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GeneralAdd.UseVisualStyleBackColor = false;
            // 
            // GeneralSettings
            // 
            this.GeneralSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GeneralSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeneralSettings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeneralSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GeneralSettings.Image = global::ProyectoFinalControlGastos.Properties.Resources.configuraciones___blanco;
            this.GeneralSettings.Location = new System.Drawing.Point(302, 10);
            this.GeneralSettings.Name = "GeneralSettings";
            this.GeneralSettings.Size = new System.Drawing.Size(121, 39);
            this.GeneralSettings.TabIndex = 4;
            this.GeneralSettings.Text = "Configuración";
            this.GeneralSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GeneralSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GeneralSettings.UseVisualStyleBackColor = false;
            this.GeneralSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalControlGastos.Properties.Resources.factura;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GeneralSettings);
            this.Controls.Add(this.GeneralAdd);
            this.Controls.Add(this.GeneralView);
            this.Controls.Add(this.GeneralTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "General";
            this.Text = "Nombre de la app";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GeneralTitle;
        private Button GeneralView;
        private Button GeneralAdd;
        private Button GeneralSettings;
        private PictureBox pictureBox1;
    }
}