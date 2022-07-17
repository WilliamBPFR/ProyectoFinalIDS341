﻿using Newtonsoft.Json;
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
            if (Correct()) {
                SaveRecord();
            }
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


        private bool Correct()
        {
            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("La contraseñas ingresadas no coinciden.\nPor Favor, escribir contraseñas que coincidan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else {
                foreach (Control item in groupBoxCreateUser.Controls)
                {
                    if ((item.Text == string.Empty || item.Text is null) && item.Name is not "textBoxOcupation" && item.Name is not "textBoxNickName") {
                        MessageBox.Show("Ha dejado elementos necesarios vacíos.\nRecuerde que solo el Nickname y la ocupación pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }      
            } 
            return true;
            }
        }
    }
 
