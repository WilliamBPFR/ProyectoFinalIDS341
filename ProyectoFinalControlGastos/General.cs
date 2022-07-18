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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            LoadName();
        }

        private void GeneralTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Settings = new Settings();
            Settings.Show();
            Hide();
        }

        private void GeneralAdd_Click(object sender, EventArgs e)
        {
            var Add = new AddTransaction();
            Add.Show();
            Hide();
        }

        private void GeneralView_Click(object sender, EventArgs e)
        {
            int cont = 0;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Transactions.json";

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile);
                foreach (Transactions item in JsonConvert.DeserializeObject<List<Transactions>>(json))
                {
                    if (item.Id == Program.logedUser.Id)
                    {
                        cont++;
                    }
                }

                if (cont != 0)
                {

                    var filtro = new Filtler();
                    filtro.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("No ha realizado ninguna transacción. Por favor realice una y vuelva a este apartado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void General_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadName()
        {
            if (Program.logedUser.NickName == string.Empty)
            {
                labelName.Text = Program.logedUser.Name;
            }
            else {
                labelName.Text = Program.logedUser.NickName;
            }

            labelID.Text = Program.logedUser.Id.ToString();
        }

        private void General_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void General_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.Cambio == false)
            {
                Application.Exit();
            }
            else
            {
            }
        }
    }
}
