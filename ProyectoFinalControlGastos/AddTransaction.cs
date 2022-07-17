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
            Add();
        }

        private void Add()
        {
            var Transaction = new Transactions()
            {
                Id = Guid.NewGuid(),
                Name = AddNameText.Text,
                Coin = comboBoxCoin.Text,
                Amount = float.Parse(AddAmountText.Text),
                Description = AddDescriptionText.Text,
                Category = comboBoxCategories.Text,
                Date = AddDateTimer.Value,
                Method = AddPagos.Text,
            };

            TransactionList.Add(Transaction);
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
            if (AddNewCategory.Text != "Añadir nuevo metodo (opcional)")
            {
                InitializeCategories(true);
            }
        }

        private void AddNewCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
