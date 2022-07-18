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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            InitializeDatos();
        }

        private void InitializeDatos()
        {
           textBoxID.Text = Program.logedUser.Id.ToString();
            textBoxNombre.Text = Program.logedUser.Name;
            textBoxApellido.Text = Program.logedUser.LastName;
            textBoxNickname.Text = Program.logedUser.NickName;
            comboBoxOcupacion.Text = Program.logedUser.Ocupation;
            textBoxEmail.Text = Program.logedUser.Email;
            comboBoxMoneda.Text = Program.logedUser.Monedas;
         
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void SaveRecord()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}users.json";
            var usersList = new List<Users>();
            var user = new Users();

            json = File.ReadAllText(pathFile);
            usersList = JsonConvert.DeserializeObject<List<Users>>(json);

            user = usersList.FirstOrDefault(x => x.Id.ToString() == textBoxID.Text);   
            usersList.Remove(user);

            user = new Users
            {
                Id = int.Parse(textBoxID.Text),
                Name = textBoxNombre.Text,
                LastName = textBoxApellido.Text,
                NickName = textBoxNickname.Text,
                Ocupation = comboBoxOcupacion.Text,
                Email = textBoxEmail.Text,
                Monedas = comboBoxMoneda.Text,
                password = Program.logedUser.password
            };
            usersList.Add(user);
            json = JsonConvert.SerializeObject(usersList);

            var Save = new StreamWriter(pathFile, false, Encoding.UTF8);
            Save.Write(json);
            Save.Close();
            Program.logedUser = user;
            MessageBox.Show("USUARIO GUARDADO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ChangePassword = new ChangePassword();
            ChangePassword.Show();
            Close();
        }


        private void btnChange_Click(object sender, EventArgs e)
        {

            string Password = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña:", "Cambiar contraseña");

            if (Password == Program.logedUser.password)
            {
                    gbPanel.Enabled = true;
                    btnChange.Enabled = false;
                    btnChangePassword.Enabled = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

            }
            else
            {
                MessageBox.Show("CONTRASEÑA INCORRECTA\nINGRESAR NUEVAMENTE");
            }
        }

        

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
