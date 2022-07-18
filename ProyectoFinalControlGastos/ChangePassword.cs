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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            textBoxID.Text = Program.logedUser.Id.ToString();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (condiciones())
            {
                SaveRecord();
                Cerrar();
                Close();

            }
            

        }

        private bool condiciones()//Verificaciones
        {
            if(textBoxActualPassword.Text != Program.logedUser.password)
            {
                MessageBox.Show("CONTRASEÑA ACTUAL INCORRECTA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if(textBoxNewPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("CONTRASEÑAS NO COINCIDEN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

            
        }

        private void SaveRecord()//Guardo el Usuario con la nueva contraseña
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
                Id = Program.logedUser.Id,
                Name = Program.logedUser.Name,
                LastName = Program.logedUser.LastName,
                NickName = Program.logedUser.NickName,
                Ocupation = Program.logedUser.Ocupation,
                Email = Program.logedUser.Email,
                Monedas = Program.logedUser.Monedas,
                password = textBoxNewPassword.Text
            };
            usersList.Add(user);
            json = JsonConvert.SerializeObject(usersList);

            var Save = new StreamWriter(pathFile, false, Encoding.UTF8);
            Save.Write(json);
            Save.Close();
            MessageBox.Show("CONTRASEÑA ACTUALIZADA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cerrar();
            Close();
        }

        private void Cerrar()
        {
           var settings = new Settings();
            settings.Show();
        }
        
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cerrar();
        }
    }
}
