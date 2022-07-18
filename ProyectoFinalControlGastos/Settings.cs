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
        public bool OriginalEmail { get; set; } = true;
        public Settings()
        {
            InitializeComponent();
            InitializeDatos();
            InicializeMonedas(false);
            InicializeOcupations(false);
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
                gbPanel.Enabled = false;
                btnChange.Enabled = true;
                btnChangePassword.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                InitializeDatos();
        }

        private void SaveRecord()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}users.json";
            var usersList = new List<Users>();
            var user = new Users();

            json = File.ReadAllText(pathFile);
            usersList = JsonConvert.DeserializeObject<List<Users>>(json);

            
            if ((usersList.Count(x => x.Email == textBoxEmail.Text) >= 1))
            {
                MessageBox.Show("El email escogido ya está en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cerrar();
            Close();
        }

        private void Cerrar()
        {
            foreach  (Form item in Application.OpenForms)
            {
                if (item is General) {
                    item.Show();
                }
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cerrar();
        }

        private void InicializeOcupations(bool adding)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ocupations.json";
            var ocupationList = new List<string>();
            string newocupation;

           
            json = File.ReadAllText(pathFile);
            ocupationList = JsonConvert.DeserializeObject<List<string>>(json);
            comboBoxOcupacion.DataSource = ocupationList;
            

            if (adding)
            {
                newocupation = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva ocupación.\nLuego pulse Aceptar para guardarla.", "Agregar Ocupación");

                if (newocupation == string.Empty || newocupation == null)
                {
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
                MessageBox.Show("La ocupación ha sido agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            json = JsonConvert.SerializeObject(ocupationList);
            var save = new StreamWriter(pathFile, false, Encoding.UTF8);
            save.Write(json);
            save.Close();

            comboBoxOcupacion.DataSource = ocupationList;

           

        }

        private void InicializeMonedas(bool adding)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\monedas.json";
            var monedaList = new List<string>();
            string newmoneda;

            
            json = File.ReadAllText(pathFile);
            monedaList = JsonConvert.DeserializeObject<List<string>>(json);
            comboBoxMoneda.DataSource = monedaList;
            
            if (adding)
            {
                newmoneda = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva moneda.\nLuego pulse Aceptar para guardarla.", "Agregar Moneda");

                if (newmoneda == string.Empty || newmoneda == null)
                {
                    return;
                }

                foreach (var item in monedaList)
                {
                    if (item.ToString().ToLower() == newmoneda.ToLower())
                    {
                        MessageBox.Show("La moneda ingresada ya existe. Busquela entre las opciones dadas", "Error de Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                monedaList.Add(newmoneda);

                MessageBox.Show("La moneda ha sido agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            json = JsonConvert.SerializeObject(monedaList);
            var save = new StreamWriter(pathFile, false, Encoding.UTF8);
            save.Write(json);
            save.Close();

            comboBoxMoneda.DataSource = monedaList;
        }

        private void AddNewCoinButton_Click(object sender, EventArgs e)
        {
            InicializeMonedas(true);
        }

        private void AddNewOcupationButton_Click(object sender, EventArgs e)
        {
            InicializeOcupations(true);
        }
    }
}
