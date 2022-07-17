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
            var filtro = new Filtler();
            filtro.Show();
        }

        private void General_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
