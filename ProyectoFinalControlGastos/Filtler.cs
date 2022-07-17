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
        public bool Closing { get; set; } = true;
        public Filtler()
        {
            InitializeComponent();
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
            string password = Microsoft.VisualBasic.Interaction.InputBox("ADAASAS", "ASAA");

            
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
    }
}
