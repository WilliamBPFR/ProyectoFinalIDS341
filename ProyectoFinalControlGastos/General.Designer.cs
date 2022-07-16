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
            this.GeneralAjustes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GeneralTitle
            // 
            this.GeneralTitle.AutoSize = true;
            this.GeneralTitle.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneralTitle.ForeColor = System.Drawing.Color.White;
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
            this.GeneralView.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.GeneralAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // GeneralAjustes
            // 
            this.GeneralAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GeneralAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneralAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeneralAjustes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeneralAjustes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GeneralAjustes.Image = global::ProyectoFinalControlGastos.Properties.Resources.configuraciones___blanco;
            this.GeneralAjustes.Location = new System.Drawing.Point(332, 10);
            this.GeneralAjustes.Name = "GeneralAjustes";
            this.GeneralAjustes.Size = new System.Drawing.Size(91, 39);
            this.GeneralAjustes.TabIndex = 4;
            this.GeneralAjustes.Text = "Ajustes";
            this.GeneralAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GeneralAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GeneralAjustes.UseVisualStyleBackColor = false;
            this.GeneralAjustes.Click += new System.EventHandler(this.button1_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.GeneralAjustes);
            this.Controls.Add(this.GeneralAdd);
            this.Controls.Add(this.GeneralView);
            this.Controls.Add(this.GeneralTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "General";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GeneralTitle;
        private Button GeneralView;
        private Button GeneralAdd;
        private Button GeneralAjustes;
    }
}