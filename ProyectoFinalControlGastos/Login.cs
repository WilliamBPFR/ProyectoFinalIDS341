using Newtonsoft.Json;
using ProyectoFinalControlGastos.Models;

namespace ProyectoFinalControlGastos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateUser_Click(object sender, EventArgs e) // Abre un form para crear usuario y esconde el de Login
        {
            var CreateUser = new CreateUser();
            CreateUser.Show();
            Hide();
        }

        private void buttonAccess_Click(object sender, EventArgs e)
        {
            LookRecord();
        }

        private void LookRecord()
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\users.json";
            var userList = new List<Users>();
            var user = new Users();

            if (File.Exists(pathFile)) {
                json = File.ReadAllText(pathFile);
                userList = JsonConvert.DeserializeObject<List<Users>>(json);
            };

            if (userList.Count(x => x.Email == textBoxEmail.Text) == 0) {
                MessageBox.Show("El usuario Ingresado no existe.\nPor favor, crear un usuario o introducir un email válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user = userList.FirstOrDefault(x => x.Email == textBoxEmail.Text);

            if (user.password != textBoxPassword.Text) {
                MessageBox.Show("La contraseña ingresada no es correcta.\nPor favor, introducir la contraseña correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.logedUser = user;

            var General = new General();
            General.Show();
            Hide();

        }
    }
}