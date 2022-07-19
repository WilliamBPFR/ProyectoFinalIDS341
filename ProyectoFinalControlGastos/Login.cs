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
            
            textBoxEmail.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }

        private void LookRecord()//Busca el usuario por email y contraseña y lo deja pasar
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\users.json";
            var userList = new List<Users>();
            var user = new Users();

            if (File.Exists(pathFile)) {
                json = File.ReadAllText(pathFile);
                userList = JsonConvert.DeserializeObject<List<Users>>(json);
            };

            if (userList.Count(x => x.Email == textBoxEmail.Text) == 0) {//Verifica que el usuario con el email introducido exista.
                MessageBox.Show("El usuario Ingresado no existe.\nPor favor, crear un usuario o introducir un email válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user = userList.FirstOrDefault(x => x.Email == textBoxEmail.Text);

            if (user.password != textBoxPassword.Text) {//Verifica que la contraseña sea igual a la que tiene el usuario registrado
                MessageBox.Show("La contraseña ingresada no es correcta.\nPor favor, introducir la contraseña correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.logedUser = user;//Guarda el usuario que se ha registrado para tener sus informaciones a la mano. Esto lo hace en la clase program

            var General = new General();
            General.Show();
            Hide();//La oculto porque como es el form principal, si lo cierro se cierra la aplicación

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}