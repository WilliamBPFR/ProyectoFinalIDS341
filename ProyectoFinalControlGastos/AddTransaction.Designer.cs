namespace ProyectoFinalControlGastos
{
    partial class AddTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransaction));
            this.AddCancel = new System.Windows.Forms.Button();
            this.AddAdd = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addNewMethod = new System.Windows.Forms.TextBox();
            this.btnAgregarMetodo = new System.Windows.Forms.Button();
            this.comboBoxCoin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPagos = new System.Windows.Forms.ComboBox();
            this.AddPago = new System.Windows.Forms.Label();
            this.AddDateTimer = new System.Windows.Forms.DateTimePicker();
            this.AddDateTime = new System.Windows.Forms.Label();
            this.AddNameText = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.Label();
            this.AddNewCategory = new System.Windows.Forms.TextBox();
            this.AddNewCategoryButtom = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.AddCategory = new System.Windows.Forms.Label();
            this.AddDescriptionText = new System.Windows.Forms.TextBox();
            this.AddDescription = new System.Windows.Forms.Label();
            this.AddAmountText = new System.Windows.Forms.TextBox();
            this.AddAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCancel
            // 
            this.AddCancel.BackColor = System.Drawing.Color.Yellow;
            this.AddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCancel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddCancel.Image = global::ProyectoFinalControlGastos.Properties.Resources.eliminar1;
            this.AddCancel.Location = new System.Drawing.Point(92, 353);
            this.AddCancel.Name = "AddCancel";
            this.AddCancel.Size = new System.Drawing.Size(121, 33);
            this.AddCancel.TabIndex = 0;
            this.AddCancel.Text = "CANCELAR";
            this.AddCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddCancel.UseVisualStyleBackColor = false;
            this.AddCancel.Click += new System.EventHandler(this.AddCancel_Click);
            // 
            // AddAdd
            // 
            this.AddAdd.BackColor = System.Drawing.Color.Lime;
            this.AddAdd.Enabled = false;
            this.AddAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAdd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddAdd.Image = global::ProyectoFinalControlGastos.Properties.Resources.mas;
            this.AddAdd.Location = new System.Drawing.Point(456, 350);
            this.AddAdd.Name = "AddAdd";
            this.AddAdd.Size = new System.Drawing.Size(99, 35);
            this.AddAdd.TabIndex = 1;
            this.AddAdd.Text = "Guardar";
            this.AddAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddAdd.UseVisualStyleBackColor = false;
            this.AddAdd.Click += new System.EventHandler(this.AddAdd_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.Location = new System.Drawing.Point(220, 351);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 35);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Aqua;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(322, 351);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 34);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(579, 31);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 29;
            this.dgvTransaction.Size = new System.Drawing.Size(433, 353);
            this.dgvTransaction.TabIndex = 23;
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew.Image")));
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.Location = new System.Drawing.Point(5, 351);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(83, 35);
            this.buttonNew.TabIndex = 24;
            this.buttonNew.Text = "New";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNewMethod);
            this.groupBox1.Controls.Add(this.btnAgregarMetodo);
            this.groupBox1.Controls.Add(this.comboBoxCoin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddPagos);
            this.groupBox1.Controls.Add(this.AddPago);
            this.groupBox1.Controls.Add(this.AddDateTimer);
            this.groupBox1.Controls.Add(this.AddDateTime);
            this.groupBox1.Controls.Add(this.AddNameText);
            this.groupBox1.Controls.Add(this.AddName);
            this.groupBox1.Controls.Add(this.AddNewCategory);
            this.groupBox1.Controls.Add(this.AddNewCategoryButtom);
            this.groupBox1.Controls.Add(this.comboBoxCategories);
            this.groupBox1.Controls.Add(this.AddCategory);
            this.groupBox1.Controls.Add(this.AddDescriptionText);
            this.groupBox1.Controls.Add(this.AddDescription);
            this.groupBox1.Controls.Add(this.AddAmountText);
            this.groupBox1.Controls.Add(this.AddAmount);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 295);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // addNewMethod
            // 
            this.addNewMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addNewMethod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewMethod.Location = new System.Drawing.Point(321, 250);
            this.addNewMethod.Name = "addNewMethod";
            this.addNewMethod.Size = new System.Drawing.Size(167, 21);
            this.addNewMethod.TabIndex = 38;
            this.addNewMethod.Text = "Añadir nuevo metodo (opcional)";
            // 
            // btnAgregarMetodo
            // 
            this.btnAgregarMetodo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarMetodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarMetodo.Location = new System.Drawing.Point(494, 250);
            this.btnAgregarMetodo.Name = "btnAgregarMetodo";
            this.btnAgregarMetodo.Size = new System.Drawing.Size(24, 21);
            this.btnAgregarMetodo.TabIndex = 37;
            this.btnAgregarMetodo.Text = "+";
            this.btnAgregarMetodo.UseVisualStyleBackColor = false;
            // 
            // comboBoxCoin
            // 
            this.comboBoxCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoin.Enabled = false;
            this.comboBoxCoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCoin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCoin.FormattingEnabled = true;
            this.comboBoxCoin.Items.AddRange(new object[] {
            "€ EUR",
            "$ USD",
            "$ DOP",
            "$ MXN",
            "Sol",
            "¥ CNY",
            "$ RUB"});
            this.comboBoxCoin.Location = new System.Drawing.Point(22, 95);
            this.comboBoxCoin.Name = "comboBoxCoin";
            this.comboBoxCoin.Size = new System.Drawing.Size(71, 23);
            this.comboBoxCoin.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Moneda";
            // 
            // AddPagos
            // 
            this.AddPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddPagos.Enabled = false;
            this.AddPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPagos.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPagos.FormattingEnabled = true;
            this.AddPagos.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Debito",
            "Tarjeta de Credito",
            "Transferencia",
            "Paypal"});
            this.AddPagos.Location = new System.Drawing.Point(321, 210);
            this.AddPagos.Name = "AddPagos";
            this.AddPagos.Size = new System.Drawing.Size(197, 23);
            this.AddPagos.TabIndex = 34;
            // 
            // AddPago
            // 
            this.AddPago.AutoSize = true;
            this.AddPago.BackColor = System.Drawing.Color.Transparent;
            this.AddPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPago.ForeColor = System.Drawing.Color.Gold;
            this.AddPago.Location = new System.Drawing.Point(325, 188);
            this.AddPago.Name = "AddPago";
            this.AddPago.Size = new System.Drawing.Size(112, 19);
            this.AddPago.TabIndex = 33;
            this.AddPago.Text = "Método de Pago";
            // 
            // AddDateTimer
            // 
            this.AddDateTimer.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddDateTimer.Enabled = false;
            this.AddDateTimer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDateTimer.Location = new System.Drawing.Point(321, 140);
            this.AddDateTimer.Name = "AddDateTimer";
            this.AddDateTimer.Size = new System.Drawing.Size(200, 21);
            this.AddDateTimer.TabIndex = 32;
            // 
            // AddDateTime
            // 
            this.AddDateTime.AutoSize = true;
            this.AddDateTime.BackColor = System.Drawing.Color.Transparent;
            this.AddDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDateTime.ForeColor = System.Drawing.Color.Gold;
            this.AddDateTime.Location = new System.Drawing.Point(325, 118);
            this.AddDateTime.Name = "AddDateTime";
            this.AddDateTime.Size = new System.Drawing.Size(141, 19);
            this.AddDateTime.TabIndex = 31;
            this.AddDateTime.Text = "Fecha de Transacción";
            // 
            // AddNameText
            // 
            this.AddNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddNameText.Enabled = false;
            this.AddNameText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNameText.Location = new System.Drawing.Point(23, 37);
            this.AddNameText.Name = "AddNameText";
            this.AddNameText.Size = new System.Drawing.Size(181, 21);
            this.AddNameText.TabIndex = 30;
            // 
            // AddName
            // 
            this.AddName.AutoSize = true;
            this.AddName.BackColor = System.Drawing.Color.Transparent;
            this.AddName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddName.ForeColor = System.Drawing.Color.Gold;
            this.AddName.Location = new System.Drawing.Point(27, 16);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(60, 19);
            this.AddName.TabIndex = 29;
            this.AddName.Text = "Nombre";
            // 
            // AddNewCategory
            // 
            this.AddNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddNewCategory.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewCategory.Location = new System.Drawing.Point(321, 77);
            this.AddNewCategory.Name = "AddNewCategory";
            this.AddNewCategory.Size = new System.Drawing.Size(167, 21);
            this.AddNewCategory.TabIndex = 28;
            this.AddNewCategory.Text = "Añadir nueva categoria (opcional)";
            // 
            // AddNewCategoryButtom
            // 
            this.AddNewCategoryButtom.BackColor = System.Drawing.Color.LimeGreen;
            this.AddNewCategoryButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNewCategoryButtom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddNewCategoryButtom.Location = new System.Drawing.Point(494, 77);
            this.AddNewCategoryButtom.Name = "AddNewCategoryButtom";
            this.AddNewCategoryButtom.Size = new System.Drawing.Size(24, 21);
            this.AddNewCategoryButtom.TabIndex = 27;
            this.AddNewCategoryButtom.Text = "+";
            this.AddNewCategoryButtom.UseVisualStyleBackColor = false;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.Enabled = false;
            this.comboBoxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCategories.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Items.AddRange(new object[] {
            "Comida",
            "Transporte",
            "Entretenimiento",
            "Salud"});
            this.comboBoxCategories.Location = new System.Drawing.Point(321, 37);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(197, 23);
            this.comboBoxCategories.TabIndex = 26;
            // 
            // AddCategory
            // 
            this.AddCategory.AutoSize = true;
            this.AddCategory.BackColor = System.Drawing.Color.Transparent;
            this.AddCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCategory.ForeColor = System.Drawing.Color.Gold;
            this.AddCategory.Location = new System.Drawing.Point(325, 15);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(163, 19);
            this.AddCategory.TabIndex = 25;
            this.AddCategory.Text = "Categoria de Transacción";
            // 
            // AddDescriptionText
            // 
            this.AddDescriptionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddDescriptionText.Enabled = false;
            this.AddDescriptionText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDescriptionText.Location = new System.Drawing.Point(23, 160);
            this.AddDescriptionText.Multiline = true;
            this.AddDescriptionText.Name = "AddDescriptionText";
            this.AddDescriptionText.Size = new System.Drawing.Size(236, 120);
            this.AddDescriptionText.TabIndex = 24;
            // 
            // AddDescription
            // 
            this.AddDescription.AutoSize = true;
            this.AddDescription.BackColor = System.Drawing.Color.Transparent;
            this.AddDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDescription.ForeColor = System.Drawing.Color.Gold;
            this.AddDescription.Location = new System.Drawing.Point(27, 139);
            this.AddDescription.Name = "AddDescription";
            this.AddDescription.Size = new System.Drawing.Size(81, 19);
            this.AddDescription.TabIndex = 23;
            this.AddDescription.Text = "Descripción";
            // 
            // AddAmountText
            // 
            this.AddAmountText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddAmountText.Enabled = false;
            this.AddAmountText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAmountText.Location = new System.Drawing.Point(109, 97);
            this.AddAmountText.Name = "AddAmountText";
            this.AddAmountText.Size = new System.Drawing.Size(95, 21);
            this.AddAmountText.TabIndex = 22;
            // 
            // AddAmount
            // 
            this.AddAmount.AutoSize = true;
            this.AddAmount.BackColor = System.Drawing.Color.Transparent;
            this.AddAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAmount.ForeColor = System.Drawing.Color.Gold;
            this.AddAmount.Location = new System.Drawing.Point(109, 75);
            this.AddAmount.Name = "AddAmount";
            this.AddAmount.Size = new System.Drawing.Size(50, 19);
            this.AddAmount.TabIndex = 21;
            this.AddAmount.Text = "Monto";
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1019, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.AddAdd);
            this.Controls.Add(this.AddCancel);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddTransaction";
            this.Text = "Añadir Transacción";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTransaction_FormClosed);
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddCancel;
        private Button AddAdd;
        private Button btnBorrar;
        private Button btnActualizar;
        private DataGridView dgvTransaction;
        private Button buttonNew;
        private GroupBox groupBox1;
        private TextBox addNewMethod;
        private Button btnAgregarMetodo;
        private ComboBox comboBoxCoin;
        private Label label1;
        private ComboBox AddPagos;
        private Label AddPago;
        private DateTimePicker AddDateTimer;
        private Label AddDateTime;
        private TextBox AddNameText;
        private Label AddName;
        private TextBox AddNewCategory;
        private Button AddNewCategoryButtom;
        private ComboBox comboBoxCategories;
        private Label AddCategory;
        private TextBox AddDescriptionText;
        private Label AddDescription;
        private TextBox AddAmountText;
        private Label AddAmount;
    }
}