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

        public bool Closing { get; set; } = true;
        public Filtler()
        {
            InitializeComponent();
            InitializeMethodsofPayments();
            InitializeMonedas();
            InitializeCategorias();
            InitializeTransactions();
        }

        private void InitializeTransactions()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Transactions.json";
            var transactionsList = new List<Transactions>();

            json = File.ReadAllText(pathFile);
            transactionsList = JsonConvert.DeserializeObject<List<Transactions>>(json);

            dgvFiltler.DataSource = transactionsList;
            LoadedTransactions = transactionsList;

            int cont = 0;

            for (int i = 0; i<NombreColumnas.Count(); i++) { 
              
                dgvFiltler.Columns[i].HeaderCell.Value = NombreColumnas[i];
                dgvFiltler.AutoResizeColumn(i);
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
        }

        private void Cerrar() {
            foreach (Form item in Application.OpenForms)
            {
                if (item is General)
                {
                    item.Show();
                    Closing = false;
                }
            }
            Close();
        }

        private void Filtler_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Closing) {
                Cerrar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (correcto()) {
                Filtlar();
            }
        }

        private bool correcto()
        {
            try
            {
                float.Parse(textBoxMonto1.Text);
            }
            catch (ArgumentOutOfRangeException e) {
                MessageBox.Show("Los valor dados en el monto no son válidos. Ingrese valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                float.Parse(textBoxMonto2.Text);
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("Los valor dados en el monto no son válidos. Ingrese valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxMonto2.Text == string.Empty && radioButtonMonto.Checked) {
                MessageBox.Show("No ha especificado la cantidad máxima a filtrar en el campo 'Monto'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else if (dateTimePicker2.Value < dateTimePicker1.Value) {
                MessageBox.Show("La fecha máxima es menor a la mínima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else if (float.Parse(textBoxMonto1.Text) > float.Parse(textBoxMonto2.Text)) {
                MessageBox.Show("El valor máximo del monto es menor que el mínimo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            }

        

        private void Filtlar()
        {
            var modifiedList = new List<Transactions>(LoadedTransactions);

            if (comboBoxCategorias.Text != "Sin Filtro" && comboBoxCategorias.Text != string.Empty) {

                foreach (Transactions item in modifiedList)
                {
                    if(modifiedList.Count == 0)
                    {
                        return;
                    }

                    if (item.Category != comboBoxCategorias.Text) {
                        modifiedList.Remove(item);
                    }
                }
            }

            if (comboBoxMetodos.Text != "Sin Filtro" && comboBoxMetodos.Text != string.Empty) {

                foreach (Transactions item in modifiedList)
                {
                    if (modifiedList.Count == 0)
                    {
                        return;
                    }
                    if (item.Method != comboBoxMetodos.Text) {
                        modifiedList.Remove(item);
                    }
                }
            }

            if (comboBoxMonedas.Text != "Sin Filtro" && comboBoxMonedas.Text != string.Empty) {

                foreach (Transactions item in modifiedList)
                {
                    if (modifiedList.Count == 0)
                    {
                        return;
                    }
                    if (item.Coin != comboBoxMonedas.Text) {
                        modifiedList.Remove(item);
                    }
                }
            }

            if (radioButtonMonto.Checked is true) {

                if (textBoxMonto1.Text == string.Empty) {
                    textBoxMonto1.Text = "0";
                }
                foreach (Transactions item in modifiedList)
                {
                    if (modifiedList.Count == 0)
                    {
                        return;
                    }
                    if (item.Amount <= float.Parse(textBoxMonto1.Text) || item.Amount >= float.Parse(textBoxMonto2.Text)) {
                        modifiedList.Remove(item);
                    }
                }
            }

            if (radioButtonFecha.Checked is true) {

                foreach (Transactions item in modifiedList)
                {
                    if (modifiedList.Count == 0)
                    {
                        return;
                    }
                    if (item.Date <= dateTimePicker1.Value || item.Date >= dateTimePicker2.Value) {
                        modifiedList.Remove(item);
                    }
                }
            }

            if (modifiedList.Count == 0)
            {
                return;
            }

            if (comboBoxName.Text != "Sin Filtro" && comboBoxName.Text != string.Empty ) {

                if (comboBoxName.Text == "A a Z")
                {
                    modifiedList.Sort((x,y) => string.Compare(x.Name, y.Name));
                    dgvFiltler.DataSource = modifiedList;
                    return;
                }
                else {
                    modifiedList.Sort((x, y) => string.Compare(x.Name, y.Name));
                    var transnew = new List<Transactions>();

                    for (int i = modifiedList.Count-1; i>=0;i--) {
                        transnew.Add(modifiedList[i]);
                    }
                    dgvFiltler.DataSource = transnew;
                    return;
                } 
            }

            dgvFiltler.DataSource = modifiedList;
        }

        private void radioButtonMonto_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMonto1.Enabled = radioButtonMonto.Checked ? true : false;
            textBoxMonto2.Enabled = radioButtonMonto.Checked ? true : false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = radioButtonFecha.Checked ? true : false;
            dateTimePicker2.Enabled = radioButtonFecha.Checked ? true : false;
        }

        private void dgvFiltler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
