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
            }
            

        }

        private bool condiciones()
        {
            if(textBoxActualPassword.Text != Program.logedUser.password)
            {
                MessageBox.Show("CONTRASEÑA ACTUAL INCORRECTA");
                return false;
            }else if(textBoxNewPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("CONTRASEÑAS NO COINCIDEN");
                return false;
            }
            return true;

            
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
            MessageBox.Show("CONTRASEÑA ACTUALIZADA");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Form1 = new Settings();
            Form1.Show();
            Close();
        }
    }
}
