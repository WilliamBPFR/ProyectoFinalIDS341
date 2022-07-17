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
        public List<string> TransCategories = new List<string>() { "Comida", "Transporte", "Entretenimiento", "Salud"};
        public AddTransaction()
        {
            InitializeComponent();
            InicializeMonedas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeCategories();
        }

        private void InitializeCategories()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\categories.json";
            var categoriesList = new List<string>();
            string category;

            if (File.Exists(pathFile))
            {

            }
            else
            {
            }
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
    }
}
