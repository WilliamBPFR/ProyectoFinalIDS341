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
                Email = textBoxEmail.Text,
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                NickName = textBoxNickName.Text,
                Ocupation = comboBoxOcupations.Text,
                password = textBoxPassword.Text,
                Monedas = comboBoxCoin.Text
            };

            if (usersList is null)
            {
                user.Id = 1100000;
            }
            else { 
                user.Id = 1100000 + usersList.Count;
            }

            int validar = usersList.Count(x => x.Email == user.Email);
            if (validar != 0) {
                MessageBox.Show("El email ingresado ya está tomado. Ingrese otro email válido", "Email No Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usersList.Add(user);

            json = JsonConvert.SerializeObject(usersList);
            var save = new StreamWriter(pathFile, false, Encoding.UTF8);
            save.Write(json);
            save.Close();

            MessageBox.Show("El ususario ha sido creadoe exitosamente", "!Craedo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clear();
        }

        public void Clear() {

            foreach (Control item in groupBoxCreateUser.Controls)
            {
                if (item is TextBox || item is ComboBox) {
                    item.Text = string.Empty;
                }
            }
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

        private void AddNewCategoryButtom_Click(object sender, EventArgs e)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ocupations.json";
            var ocupationList = new List<string>();
            string newocupation; 

            if (File.Exists(pathFile)) {
                json = File.ReadAllText(pathFile);
                ocupationList = JsonConvert.DeserializeObject<List<string>>(json);
            }

            newocupation = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva ocupación.\nLuego pulse Aceptar para guardarla.", "Agregar Ocupación");

            if (newocupation == string.Empty || newocupation == null) {
                return;
            }

            foreach (var item in ocupationList)
            {
                if (item.ToString().ToLower() == newocupation.ToLower())
                {
                    MessageBox.Show("La ocupación ingresada ya existe. Busquela entre las opciones dadas", "Error de Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            ocupationList.Add(newocupation);

            json = JsonConvert.SerializeObject(ocupationList);
            var save = new StreamWriter(pathFile, false, Encoding.UTF8);
            save.Write(json);
            save.Close();

            comboBoxOcupations.DataSource = ocupationList;

                MessageBox.Show("La ocupación ha sido agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxOcupations_Enter(object sender, EventArgs e)
        {

        }
    }
}
 
