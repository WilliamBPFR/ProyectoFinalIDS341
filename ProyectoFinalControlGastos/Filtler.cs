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
        public List<string> NombreColumnas = new List<string> { "Nombre", "Categoría de Transacción", "Moneda", "Cantidad", "Método de Pago", "Id", "Fecha de Creación", "Descripción"};
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

            comboBoxCategorias.DataSource = categoriesList;
        }

        private void InitializeMonedas()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\monedas.json";
            var monedasList = new List<string>();

            json = File.ReadAllText(pathFile);
            monedasList = JsonConvert.DeserializeObject<List<string>>(json);

            comboBoxMonedas.DataSource = monedasList;
        }

        private void InitializeMethodsofPayments()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\MetodosDePago.json";
            var methodsList = new List<string>();

            json = File.ReadAllText(pathFile);
            methodsList = JsonConvert.DeserializeObject<List<string>>(json);

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
        }
    }
}
