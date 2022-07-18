namespace ProyectoFinalControlGastos
{
    partial class Filtler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFiltler = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.comboBoxMonedas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMonto1 = new System.Windows.Forms.TextBox();
            this.textBoxMonto2 = new System.Windows.Forms.TextBox();
            this.comboBoxMetodos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonFiltro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxMonto = new System.Windows.Forms.CheckBox();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(499, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtra tus Transacciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(549, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(295, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Moneda:";
            // 
            // dgvFiltler
            // 
            this.dgvFiltler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltler.Enabled = false;
            this.dgvFiltler.Location = new System.Drawing.Point(24, 208);
            this.dgvFiltler.Name = "dgvFiltler";
            this.dgvFiltler.RowTemplate.Height = 25;
            this.dgvFiltler.Size = new System.Drawing.Size(1024, 230);
            this.dgvFiltler.TabIndex = 9;
            this.dgvFiltler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltler_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(159, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Categoría:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(429, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Método de Pago:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Items.AddRange(new object[] {
            "Sin Filtro",
            "A a Z",
            "Z a A"});
            this.comboBoxName.Location = new System.Drawing.Point(24, 119);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(110, 23);
            this.comboBoxName.TabIndex = 15;
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCategorias.Items.AddRange(new object[] {
            "A a Z",
            "Z a A"});
            this.comboBoxCategorias.Location = new System.Drawing.Point(159, 119);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(110, 23);
            this.comboBoxCategorias.TabIndex = 16;
            // 
            // comboBoxMonedas
            // 
            this.comboBoxMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonedas.FormattingEnabled = true;
            this.comboBoxMonedas.Items.AddRange(new object[] {
            "A a Z",
            "Z a A"});
            this.comboBoxMonedas.Location = new System.Drawing.Point(297, 119);
            this.comboBoxMonedas.Name = "comboBoxMonedas";
            this.comboBoxMonedas.Size = new System.Drawing.Size(110, 23);
            this.comboBoxMonedas.TabIndex = 17;
            this.comboBoxMonedas.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(610, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "De:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(613, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "A:";
            // 
            // textBoxMonto1
            // 
            this.textBoxMonto1.Enabled = false;
            this.textBoxMonto1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMonto1.Location = new System.Drawing.Point(647, 119);
            this.textBoxMonto1.Name = "textBoxMonto1";
            this.textBoxMonto1.Size = new System.Drawing.Size(59, 26);
            this.textBoxMonto1.TabIndex = 20;
            // 
            // textBoxMonto2
            // 
            this.textBoxMonto2.Enabled = false;
            this.textBoxMonto2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMonto2.Location = new System.Drawing.Point(647, 148);
            this.textBoxMonto2.Name = "textBoxMonto2";
            this.textBoxMonto2.Size = new System.Drawing.Size(59, 26);
            this.textBoxMonto2.TabIndex = 21;
            // 
            // comboBoxMetodos
            // 
            this.comboBoxMetodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetodos.FormattingEnabled = true;
            this.comboBoxMetodos.Items.AddRange(new object[] {
            "A a Z",
            "Z a A"});
            this.comboBoxMetodos.Location = new System.Drawing.Point(429, 119);
            this.comboBoxMetodos.Name = "comboBoxMetodos";
            this.comboBoxMetodos.Size = new System.Drawing.Size(164, 23);
            this.comboBoxMetodos.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(733, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Hasta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(731, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Desde:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(802, 116);
            this.dateTimePicker1.MaxDate = new System.DateTime(3515, 7, 15, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 26);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 17, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker2.Location = new System.Drawing.Point(802, 152);
            this.dateTimePicker2.MaxDate = new System.DateTime(3515, 7, 15, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(84, 26);
            this.dateTimePicker2.TabIndex = 28;
            this.dateTimePicker2.Value = new System.DateTime(2022, 7, 17, 0, 0, 0, 0);
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.BackColor = System.Drawing.Color.Red;
            this.buttonFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFiltro.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFiltro.ForeColor = System.Drawing.Color.White;
            this.buttonFiltro.Image = global::ProyectoFinalControlGastos.Properties.Resources.image_processing20210207_6297_at8381__1_;
            this.buttonFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFiltro.Location = new System.Drawing.Point(935, 116);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(111, 56);
            this.buttonFiltro.TabIndex = 29;
            this.buttonFiltro.Text = "Filtrar";
            this.buttonFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiltro.UseVisualStyleBackColor = false;
            this.buttonFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::ProyectoFinalControlGastos.Properties.Resources._120826__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 30;
            this.button2.Text = "Regresar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxMonto
            // 
            this.checkBoxMonto.AutoSize = true;
            this.checkBoxMonto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMonto.ForeColor = System.Drawing.Color.White;
            this.checkBoxMonto.Location = new System.Drawing.Point(622, 93);
            this.checkBoxMonto.Name = "checkBoxMonto";
            this.checkBoxMonto.Size = new System.Drawing.Size(88, 26);
            this.checkBoxMonto.TabIndex = 36;
            this.checkBoxMonto.Text = "Monto:";
            this.checkBoxMonto.UseVisualStyleBackColor = true;
            this.checkBoxMonto.CheckedChanged += new System.EventHandler(this.checkBoxMonto_CheckedChanged);
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFecha.ForeColor = System.Drawing.Color.White;
            this.checkBoxFecha.Location = new System.Drawing.Point(716, 93);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(214, 26);
            this.checkBoxFecha.TabIndex = 37;
            this.checkBoxFecha.Text = "Fecha de Transacción:";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            this.checkBoxFecha.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // Filtler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.checkBoxMonto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxMetodos);
            this.Controls.Add(this.textBoxMonto2);
            this.Controls.Add(this.textBoxMonto1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMonedas);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvFiltler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Filtler";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Filtler_FormClosed);
            this.Load += new System.EventHandler(this.Filtler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvFiltler;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxName;
        private ComboBox comboBoxCategorias;
        private ComboBox comboBoxMonedas;
        private Label label6;
        private Label label10;
        private TextBox textBoxMonto1;
        private TextBox textBoxMonto2;
        private ComboBox comboBoxMetodos;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button buttonFiltro;
        private Button button2;
        private CheckBox checkBoxMonto;
        private CheckBox checkBoxFecha;
    }
}