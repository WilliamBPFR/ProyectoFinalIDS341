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
    public partial class AddTransaction : Form
    {
        List<Transactions> TransactionList = new List<Transactions>();

        public List<string> TransCategories = new List<string>() { "Comida", "Transporte", "Entretenimiento", "Salud"};
        public AddTransaction()
        {
            InitializeComponent();
            InicializeMonedas();
            InitializeCategories(false);
            MetodosDePago(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddNewCategory.Text != "Añadir nueva categoria (opcional)") {
                InitializeCategories(true);
            }
        }

        private void InitializeCategories(bool adding)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\categories.json";
            var categoriesList = new List<string>();
            string newcategory;

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile);
                categoriesList = JsonConvert.DeserializeObject<List<string>>(json);
                comboBoxCategories.DataSource = categoriesList;
            }
            else
            {
                categoriesList = TransCategories;
                comboBoxCategories.DataSource = categoriesList;
            }

            if (adding) {

                if (AddNewCategory.Text == string.Empty) {
                    MessageBox.Show("No puede agregar una categoría vacía.\nRecuerde que debe llenar el campo y luego presionar el botón de '+'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newcategory = AddNewCategory.Text;

                foreach (var item in categoriesList)
                {
                    if (item == newcategory) {
                        MessageBox.Show("La categoría existe.\nTrate de revisar bien las opciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                categoriesList.Add(newcategory);
                MessageBox.Show("La categoría ha sido agregada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNewCategory.Text = "Añadir nueva categoria (opcional)";
            }

              json = JsonConvert.SerializeObject(categoriesList);
              var save = new StreamWriter(pathFile, false, Encoding.UTF8);
              save.Write(json);
              save.Close();
            comboBoxCategories.DataSource = categoriesList;
        }
        

        private void AddCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddCancel_Click(object sender, EventArgs e)
        {
            var General = new General();
            General.Show();
            Hide();
        }

        private void AddAdd_Click(object sender, EventArgs e)
        {
            Add(true);
        }

        private void Add(bool adding)
        {
            var json = string.Empty;
            var TransactionsList = new List<Transactions>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Transactions.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                TransactionsList = JsonConvert.DeserializeObject<List<Transactions>>(json);
            }

            var Transaction1 = new Transactions();
            if (adding)
            {
                Transaction1 = new Transactions
                {
                    Id = Program.logedUser.Id,
                    Name = AddNameText.Text,
                    Coin = comboBoxCoin.Text,
                    Amount = float.Parse(AddAmountText.Text),
                    Description = AddDescriptionText.Text,
                    Category = comboBoxCategories.Text,
                    Date = AddDateTimer.Value,
                    Method = AddPagos.Text,
                };

                TransactionsList.Add(Transaction1);
                                            
            }
            json = JsonConvert.SerializeObject(TransactionsList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
        }

            private void InicializeMonedas()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\monedas.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile);
                comboBoxCoin.DataSource = JsonConvert.DeserializeObject<List<string>>(json);
            }
        }
        private void AddTransaction_Load(object sender, EventArgs e)
        {

        }

        private void AddNewCategory_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewCategory.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (addNewMethod.Text != "Añadir nuevo metodo (opcional)")
            {
                MetodosDePago(true);
            }

        }
        private void MetodosDePago(bool adding)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\MetodosDePago.json";
            var MetodosDePago = new List<string>();
            string newmethod;

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile);
                MetodosDePago = JsonConvert.DeserializeObject<List<string>>(json);
                AddPagos.DataSource = MetodosDePago;
            }
            else
            {
                MetodosDePago = TransCategories;
                AddPagos.DataSource = MetodosDePago;
            }

            if (adding)
            {

                if (addNewMethod.Text == string.Empty)
                {
                    MessageBox.Show("No puede agregar un método vacío.\nRecuerde que debe llenar el campo y luego presionar el botón de '+'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newmethod = addNewMethod.Text;

                foreach (var item in MetodosDePago)
                {
                    if (item == newmethod)
                    {
                        MessageBox.Show("El método existe.\nTrate de revisar bien las opciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MetodosDePago.Add(newmethod);
                MessageBox.Show("El método ha sido agregado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addNewMethod.Text = "Añadir nuevo método (opcional)";
            }

            json = JsonConvert.SerializeObject(MetodosDePago);
            var save = new StreamWriter(pathFile, false, Encoding.UTF8);
            save.Write(json);
            save.Close();
            AddPagos.DataSource = MetodosDePago;
        }


        private void AddNewCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPagos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
