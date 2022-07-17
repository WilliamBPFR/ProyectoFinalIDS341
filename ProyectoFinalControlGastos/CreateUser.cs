using Newtonsoft.Json;
using ProyectoFinalControlGastos.Models;
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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            CloseForm();
        }

        private void CloseForm()//Busca el Form de Login Original y lo muestra
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item is Login)
                {
                    item.Show();
                }
            }
        }

        private void CreateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void SaveRecord()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}users.json";
            var usersList = new List<Users>();
            var user = new Users();

            if (File.Exists(pathFile)) {
                
                json = File.ReadAllText(pathFile);
                usersList = JsonConvert.DeserializeObject<List<Users>>(json);
            }

            user = new Users
            {
                Id = 1100000 + (usersList.Count),
                Email = textBoxEmail.Text,
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                NickName = textBoxNickName.Text,
                Ocupation = textBoxOcupation.Text,
                password = textBoxPassword.Text,
                Monedas = comboBoxCoin.Text
            };
        }
    }
}
