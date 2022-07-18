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
            this.AddCancel = new System.Windows.Forms.Button();
            this.AddAdd = new System.Windows.Forms.Button();
            this.AddAmount = new System.Windows.Forms.Label();
            this.AddAmountText = new System.Windows.Forms.TextBox();
            this.AddDescriptionText = new System.Windows.Forms.TextBox();
            this.AddDescription = new System.Windows.Forms.Label();
            this.AddCategory = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.AddNewCategoryButtom = new System.Windows.Forms.Button();
            this.AddNewCategory = new System.Windows.Forms.TextBox();
            this.AddNameText = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.Label();
            this.AddDateTime = new System.Windows.Forms.Label();
            this.AddDateTimer = new System.Windows.Forms.DateTimePicker();
            this.AddPagos = new System.Windows.Forms.ComboBox();
            this.AddPago = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCoin = new System.Windows.Forms.ComboBox();
            this.addNewMethod = new System.Windows.Forms.TextBox();
            this.btnAgregarMetodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCancel
            // 
            this.AddCancel.BackColor = System.Drawing.Color.Red;
            this.AddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCancel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddCancel.Image = global::ProyectoFinalControlGastos.Properties.Resources.eliminar1;
            this.AddCancel.Location = new System.Drawing.Point(89, 376);
            this.AddCancel.Name = "AddCancel";
            this.AddCancel.Size = new System.Drawing.Size(164, 35);
            this.AddCancel.TabIndex = 0;
            this.AddCancel.Text = "CANCELAR";
            this.AddCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddCancel.UseVisualStyleBackColor = false;
            this.AddCancel.Click += new System.EventHandler(this.AddCancel_Click);
            // 
            // AddAdd
            // 
            this.AddAdd.BackColor = System.Drawing.Color.Aqua;
            this.AddAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAdd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddAdd.Image = global::ProyectoFinalControlGastos.Properties.Resources.mas;
            this.AddAdd.Location = new System.Drawing.Point(327, 376);
            this.AddAdd.Name = "AddAdd";
            this.AddAdd.Size = new System.Drawing.Size(164, 35);
            this.AddAdd.TabIndex = 1;
            this.AddAdd.Text = "AÑADIR";
            this.AddAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddAdd.UseVisualStyleBackColor = false;
            this.AddAdd.Click += new System.EventHandler(this.AddAdd_Click);
            // 
            // AddAmount
            // 
            this.AddAmount.AutoSize = true;
            this.AddAmount.BackColor = System.Drawing.Color.Transparent;
            this.AddAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAmount.ForeColor = System.Drawing.Color.Gold;
            this.AddAmount.Location = new System.Drawing.Point(115, 102);
            this.AddAmount.Name = "AddAmount";
            this.AddAmount.Size = new System.Drawing.Size(50, 19);
            this.AddAmount.TabIndex = 2;
            this.AddAmount.Text = "Monto";
            // 
            // AddAmountText
            // 
            this.AddAmountText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddAmountText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAmountText.Location = new System.Drawing.Point(115, 124);
            this.AddAmountText.Name = "AddAmountText";
            this.AddAmountText.Size = new System.Drawing.Size(95, 21);
            this.AddAmountText.TabIndex = 3;
            // 
            // AddDescriptionText
            // 
            this.AddDescriptionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddDescriptionText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDescriptionText.Location = new System.Drawing.Point(29, 187);
            this.AddDescriptionText.Multiline = true;
            this.AddDescriptionText.Name = "AddDescriptionText";
            this.AddDescriptionText.Size = new System.Drawing.Size(236, 120);
            this.AddDescriptionText.TabIndex = 5;
            // 
            // AddDescription
            // 
            this.AddDescription.AutoSize = true;
            this.AddDescription.BackColor = System.Drawing.Color.Transparent;
            this.AddDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDescription.ForeColor = System.Drawing.Color.Gold;
            this.AddDescription.Location = new System.Drawing.Point(33, 166);
            this.AddDescription.Name = "AddDescription";
            this.AddDescription.Size = new System.Drawing.Size(81, 19);
            this.AddDescription.TabIndex = 4;
            this.AddDescription.Text = "Descripción";
            // 
            // AddCategory
            // 
            this.AddCategory.AutoSize = true;
            this.AddCategory.BackColor = System.Drawing.Color.Transparent;
            this.AddCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCategory.ForeColor = System.Drawing.Color.Gold;
            this.AddCategory.Location = new System.Drawing.Point(331, 42);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(163, 19);
            this.AddCategory.TabIndex = 6;
            this.AddCategory.Text = "Categoria de Transacción";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCategories.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Items.AddRange(new object[] {
            "Comida",
            "Transporte",
            "Entretenimiento",
            "Salud"});
            this.comboBoxCategories.Location = new System.Drawing.Point(327, 64);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(197, 23);
            this.comboBoxCategories.TabIndex = 7;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.AddCategories_SelectedIndexChanged);
            // 
            // AddNewCategoryButtom
            // 
            this.AddNewCategoryButtom.BackColor = System.Drawing.Color.LimeGreen;
            this.AddNewCategoryButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNewCategoryButtom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddNewCategoryButtom.Location = new System.Drawing.Point(500, 104);
            this.AddNewCategoryButtom.Name = "AddNewCategoryButtom";
            this.AddNewCategoryButtom.Size = new System.Drawing.Size(24, 21);
            this.AddNewCategoryButtom.TabIndex = 8;
            this.AddNewCategoryButtom.Text = "+";
            this.AddNewCategoryButtom.UseVisualStyleBackColor = false;
            this.AddNewCategoryButtom.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewCategory
            // 
            this.AddNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddNewCategory.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewCategory.Location = new System.Drawing.Point(327, 104);
            this.AddNewCategory.Name = "AddNewCategory";
            this.AddNewCategory.Size = new System.Drawing.Size(167, 21);
            this.AddNewCategory.TabIndex = 10;
            this.AddNewCategory.Text = "Añadir nueva categoria (opcional)";
            this.AddNewCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddNewCategory_MouseClick);
            this.AddNewCategory.TextChanged += new System.EventHandler(this.AddNewCategory_TextChanged);
            // 
            // AddNameText
            // 
            this.AddNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddNameText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNameText.Location = new System.Drawing.Point(29, 64);
            this.AddNameText.Name = "AddNameText";
            this.AddNameText.Size = new System.Drawing.Size(181, 21);
            this.AddNameText.TabIndex = 12;
            this.AddNameText.TextChanged += new System.EventHandler(this.AddNameText_TextChanged);
            // 
            // AddName
            // 
            this.AddName.AutoSize = true;
            this.AddName.BackColor = System.Drawing.Color.Transparent;
            this.AddName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddName.ForeColor = System.Drawing.Color.Gold;
            this.AddName.Location = new System.Drawing.Point(33, 43);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(60, 19);
            this.AddName.TabIndex = 11;
            this.AddName.Text = "Nombre";
            // 
            // AddDateTime
            // 
            this.AddDateTime.AutoSize = true;
            this.AddDateTime.BackColor = System.Drawing.Color.Transparent;
            this.AddDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDateTime.ForeColor = System.Drawing.Color.Gold;
            this.AddDateTime.Location = new System.Drawing.Point(331, 145);
            this.AddDateTime.Name = "AddDateTime";
            this.AddDateTime.Size = new System.Drawing.Size(141, 19);
            this.AddDateTime.TabIndex = 13;
            this.AddDateTime.Text = "Fecha de Transacción";
            // 
            // AddDateTimer
            // 
            this.AddDateTimer.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddDateTimer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDateTimer.Location = new System.Drawing.Point(327, 167);
            this.AddDateTimer.Name = "AddDateTimer";
            this.AddDateTimer.Size = new System.Drawing.Size(200, 21);
            this.AddDateTimer.TabIndex = 14;
            // 
            // AddPagos
            // 
            this.AddPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPagos.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPagos.FormattingEnabled = true;
            this.AddPagos.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Debito",
            "Tarjeta de Credito",
            "Transferencia",
            "Paypal"});
            this.AddPagos.Location = new System.Drawing.Point(327, 237);
            this.AddPagos.Name = "AddPagos";
            this.AddPagos.Size = new System.Drawing.Size(197, 23);
            this.AddPagos.TabIndex = 16;
            this.AddPagos.SelectedIndexChanged += new System.EventHandler(this.AddPagos_SelectedIndexChanged);
            // 
            // AddPago
            // 
            this.AddPago.AutoSize = true;
            this.AddPago.BackColor = System.Drawing.Color.Transparent;
            this.AddPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPago.ForeColor = System.Drawing.Color.Gold;
            this.AddPago.Location = new System.Drawing.Point(331, 215);
            this.AddPago.Name = "AddPago";
            this.AddPago.Size = new System.Drawing.Size(112, 19);
            this.AddPago.TabIndex = 15;
            this.AddPago.Text = "Método de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Moneda";
            // 
            // comboBoxCoin
            // 
            this.comboBoxCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboBoxCoin.Location = new System.Drawing.Point(28, 122);
            this.comboBoxCoin.Name = "comboBoxCoin";
            this.comboBoxCoin.Size = new System.Drawing.Size(71, 23);
            this.comboBoxCoin.TabIndex = 18;
            // 
            // addNewMethod
            // 
            this.addNewMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addNewMethod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewMethod.Location = new System.Drawing.Point(327, 277);
            this.addNewMethod.Name = "addNewMethod";
            this.addNewMethod.Size = new System.Drawing.Size(167, 21);
            this.addNewMethod.TabIndex = 20;
            this.addNewMethod.Text = "Añadir nuevo metodo (opcional)";
            this.addNewMethod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addNewMethod_MouseClick);
            this.addNewMethod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAgregarMetodo
            // 
            this.btnAgregarMetodo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarMetodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarMetodo.Location = new System.Drawing.Point(500, 277);
            this.btnAgregarMetodo.Name = "btnAgregarMetodo";
            this.btnAgregarMetodo.Size = new System.Drawing.Size(24, 21);
            this.btnAgregarMetodo.TabIndex = 19;
            this.btnAgregarMetodo.Text = "+";
            this.btnAgregarMetodo.UseVisualStyleBackColor = false;
            this.btnAgregarMetodo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(587, 483);
            this.Controls.Add(this.addNewMethod);
            this.Controls.Add(this.btnAgregarMetodo);
            this.Controls.Add(this.comboBoxCoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPagos);
            this.Controls.Add(this.AddPago);
            this.Controls.Add(this.AddDateTimer);
            this.Controls.Add(this.AddDateTime);
            this.Controls.Add(this.AddNameText);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.AddNewCategory);
            this.Controls.Add(this.AddNewCategoryButtom);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.AddDescriptionText);
            this.Controls.Add(this.AddDescription);
            this.Controls.Add(this.AddAmountText);
            this.Controls.Add(this.AddAmount);
            this.Controls.Add(this.AddAdd);
            this.Controls.Add(this.AddCancel);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddTransaction";
            this.Text = "Añadir Transacción";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddCancel;
        private Button AddAdd;
        private Label AddAmount;
        private TextBox AddAmountText;
        private TextBox AddDescriptionText;
        private Label AddDescription;
        private Label AddCategory;
        private ComboBox comboBoxCategories;
        private Button AddNewCategoryButtom;
        private TextBox AddNewCategory;
        private TextBox AddNameText;
        private Label AddName;
        private Label AddDateTime;
        private DateTimePicker AddDateTimer;
        private ComboBox AddPagos;
        private Label AddPago;
        private Label label1;
        private ComboBox comboBoxCoin;
        private TextBox addNewMethod;
        private Button btnAgregarMetodo;
    }
}