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
        public List <string> OList = new List<string> { "Ingeniero", "Abogado", "Enfermero"};
        public List <string> Monedas = new List<string> { "€ EUR", "$ USD", "$ DOP", "$ MXN", "Sol", "¥ CNY", "$ RUB"};
        public CreateUser()
        {
            InitializeComponent();
            InicializeOcupations(false);
            InicializeMonedas(false);
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

        private void SaveRecord()//Guarda los Datos en el Json
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

            if (usersList is null)//Comprueba si hay usuarios, si hay los suma al id inicial y si no le asigna el id inicial
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

            MessageBox.Show("El ususario ha sido creadoe exitosamente", "!Craedo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        public void Clear()// Limpia los datos de los textbox y los comboBOx 
        {

            foreach (Control item in groupBoxCreateUser.Controls)
            {
                if (item is TextBox || item is ComboBox) {
                    item.Text = string.Empty;
                }
            }
        }

        private bool Correct()//Verificaciones antes de guardar
        {
            if (textBoxPassword.Text != textBoxRepeatPassword.Text)//Que ambas contraseñas sean iguales.
            {
                MessageBox.Show("La contraseñas ingresadas no coinciden.\nPor Favor, escribir contraseñas que coincidan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else {
                foreach (Control item in groupBoxCreateUser.Controls)//Que los campos no esten vacios a excepcion de NickName y Ocupacion
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
            InicializeOcupations(true);
        }

        private void comboBoxOcupations_Enter(object sender, EventArgs e)
        {

        }

        private void InicializeOcupations(bool adding) {//Carga y Crea las Ocupaciones
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ocupations.json";
            var ocupationList = new List<string>();
            string newocupation;

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile);
                ocupationList = JsonConvert.DeserializeObject<List<string>>(json);
                comboBoxOcupations.DataSource = ocupationList;
            }
            else {
                ocupationList = OList;
                comboBoxOcupations.DataSource = OList;
            }

            if (adding)// Cuando Se añade con el boton de "+"
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
                comboBoxOcupations.DataSource = ocupationList;

            }

        private void InicializeMonedas(bool adding)//Carga y Crea las Monedas
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\monedas.json";
            var monedaList = new List<string>();
            string newmoneda;

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile);
                monedaList = JsonConvert.DeserializeObject<List<string>>(json);
                comboBoxCoin.DataSource = monedaList;
            }
            else {
                monedaList = Monedas;
                comboBoxCoin.DataSource = monedaList;
            }

            if (adding)// Cuando Se añade con el boton de "+"
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

                comboBoxCoin.DataSource = monedaList;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicializeMonedas(true);
        }

        private void comboBoxCoin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOcupations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
 
