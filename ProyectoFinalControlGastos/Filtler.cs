using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalControlGastos
{
    public partial class Filtler : Form
    {
        public List<string> NombreColumnas = new List<string> { "ID", "Nombre", "Categoría de Transacción", "Moneda", "Cantidad", "Método de Pago", "Id", "Fecha de Creación", "Descripción"};
        
        public List<Transactions> LoadedTransactions = new List<Transactions>();

        public int TransElements { get; set; } = 0;
        public Filtler()
        {
            InitializeComponent();
            InitializeMethodsofPayments();
            InitializeMonedas();
            InitializeCategorias();
            InitializeTransactions(true);
        }

        private void InitializeTransactions(bool inicio)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Transactions.json";
            var transactionsList = new List<Transactions>();

            json = File.ReadAllText(pathFile);
            transactionsList = JsonConvert.DeserializeObject<List<Transactions>>(json);

            LoadedTransactions.Clear();
            foreach (Transactions item in transactionsList)
            {
                if (item.Id == Program.logedUser.Id)
                {
                    LoadedTransactions.Add(item);
                }
            }

            dgvFiltler.DataSource = LoadedTransactions;
            TransElements = LoadedTransactions.Count;
            if (inicio) { 
            for (int i = 0; i < NombreColumnas.Count(); i++)
            {
                dgvFiltler.Columns[i].HeaderCell.Value = NombreColumnas[i];
                dgvFiltler.AutoResizeColumn(i);
            }
        }
     }   

        private void InitializeCategorias()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\categories.json";
            var categoriesList = new List<string>();

            json = File.ReadAllText(pathFile);
            categoriesList = JsonConvert.DeserializeObject<List<string>>(json);

            categoriesList.Add("Sin Filtro");

            comboBoxCategorias.DataSource = categoriesList;
        }

        private void InitializeMonedas()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\monedas.json";
            var monedasList = new List<string>();

            json = File.ReadAllText(pathFile);
            monedasList = JsonConvert.DeserializeObject<List<string>>(json);

            monedasList.Add("Sin Filtro");
            comboBoxMonedas.DataSource = monedasList;
        }

        private void InitializeMethodsofPayments()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\MetodosDePago.json";
            var methodsList = new List<string>();

            json = File.ReadAllText(pathFile);
            methodsList = JsonConvert.DeserializeObject<List<string>>(json);

            methodsList.Add("Sin Filtro");
            comboBoxMetodos.DataSource = methodsList;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Filtler_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cerrar();
            Close();
        }

        private void Cerrar() {
            foreach (Form item in Application.OpenForms)
            {
                if (item is General)
                {
                    item.Show();
                }
            }
        }

        private void Filtler_FormClosed(object sender, FormClosedEventArgs e)
        {
                Cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (correcto()) {
                Filtlar();
            }
        }

        private bool correcto()
        {
            if (checkBoxMonto.Checked) {
                try
                {
                    float.Parse(textBoxMonto1.Text);
                }
                catch (FormatException e) {
                    if (textBoxMonto1.Text == string.Empty)
                    {
                        textBoxMonto1.Text = "0";
                    }
                    else {    
                        MessageBox.Show("Los valor dados en el monto no son válidos. Ingrese valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            
                try
                 {
                float.Parse(textBoxMonto2.Text);
                }
                 catch (FormatException e)
                {
                MessageBox.Show("Los valor dados en el monto no son válidos. Ingrese valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }
            }

            
            if (textBoxMonto2.Text == string.Empty && checkBoxMonto.Checked) {
                MessageBox.Show("No ha especificado la cantidad máxima a filtrar en el campo 'Monto'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else if ((dateTimePicker2.Value < dateTimePicker1.Value) && checkBoxFecha.Checked) {
                MessageBox.Show("La fecha máxima es menor a la mínima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else if (checkBoxMonto.Checked) {
                if (float.Parse(textBoxMonto1.Text) > float.Parse(textBoxMonto2.Text)) {
                    MessageBox.Show("El valor máximo del monto es menor que el mínimo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
            }

        private void Filtlar()
        {
            InitializeTransactions(false);
            
            var modifiedList = new List<Transactions>();

            if (comboBoxCategorias.Text != "Sin Filtro" && comboBoxCategorias.Text != string.Empty) {

                foreach (Transactions item in LoadedTransactions)
                {
                    if (item.Category != comboBoxCategorias.Text)
                    {
                        modifiedList.Add(item);
                    }
                }
                foreach (Transactions item in modifiedList)
                {
                    LoadedTransactions.Remove(item);
                }
                modifiedList.Clear();
            }

            if (comboBoxMetodos.Text != "Sin Filtro" && comboBoxMetodos.Text != string.Empty) {

                foreach (Transactions item in LoadedTransactions)
                {
                    if (item.Method != comboBoxMetodos.Text) {
                        modifiedList.Add(item);
                    }
                }
                foreach (Transactions item in modifiedList)
                {
                    LoadedTransactions.Remove(item);
                }
                modifiedList.Clear();
            }

            if (comboBoxMonedas.Text != "Sin Filtro" && comboBoxMonedas.Text != string.Empty) {

                foreach (Transactions item in LoadedTransactions)
                {
                    if (item.Coin != comboBoxMonedas.Text) {
                        modifiedList.Add(item);

                    }
                }
                foreach (Transactions item in modifiedList)
                {
                    LoadedTransactions.Remove(item);
                }
                modifiedList.Clear();
            }

            if (checkBoxMonto.Checked is true) {

                if (textBoxMonto1.Text == string.Empty) {
                    textBoxMonto1.Text = "0";
                }
                foreach (Transactions item in LoadedTransactions)
                {
                    if (item.Amount < float.Parse(textBoxMonto1.Text) || item.Amount > float.Parse(textBoxMonto2.Text)) {
                        modifiedList.Add(item);
                    }
                }
                foreach (Transactions item in modifiedList)
                {
                    LoadedTransactions.Remove(item);
                }
                modifiedList.Clear();
            }

            if (checkBoxFecha.Checked is true) {

                foreach (Transactions item in LoadedTransactions)
                {
                    if (item.Date < dateTimePicker1.Value || item.Date > dateTimePicker2.Value) {
                        modifiedList.Add(item);
                
                    }
                }
                foreach (Transactions item in modifiedList)
                {
                    LoadedTransactions.Remove(item);
                }
                modifiedList.Clear();
            }

            if (comboBoxName.Text != "Sin Filtro" && comboBoxName.Text != string.Empty ) {

                if (comboBoxName.Text == "A a Z")
                {
                    LoadedTransactions.Sort((x,y) => string.Compare(x.Name, y.Name));
                    dgvFiltler.DataSource = LoadedTransactions;
                    dgvFiltler.Refresh();
                    return;
                }
                else {
                   LoadedTransactions.Sort((x, y) => string.Compare(x.Name, y.Name));
                    var transnew = new List<Transactions>();

                    for (int i = LoadedTransactions.Count-1; i>=0;i--) {
                        transnew.Add(LoadedTransactions[i]);
                    }
                    dgvFiltler.DataSource = transnew;
                    dgvFiltler.Refresh();
                    return;
                } 
            }
            var lastrans = new List<Transactions>();

            foreach (Transactions item in LoadedTransactions)
            {
                lastrans.Add(item);
            }
            dgvFiltler.DataSource = lastrans;
            dgvFiltler.Refresh();
        }

        private void radioButtonMonto_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvFiltler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonMonto_MouseClick(object sender, MouseEventArgs e)
        {  
        }

        private void radioButtonFecha_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void checkBoxMonto_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMonto1.Enabled = checkBoxMonto.Checked ? true : false;
            textBoxMonto2.Enabled = checkBoxMonto.Checked ? true : false;
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBoxFecha.Checked ? true : false;
            dateTimePicker2.Enabled = checkBoxFecha.Checked ? true : false;
        }
    }
}
