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
        public AddTransaction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            AddCategories.Items.Add(AddNewCategory.Text);
            
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
    }
}
