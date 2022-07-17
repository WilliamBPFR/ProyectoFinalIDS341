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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            InitializeDatos();
        }

        private void InitializeDatos()
        {
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();

            foreach (Form item in Application.OpenForms)
            {
                if (item is Login) {
                    item.Show();
                    return;
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
