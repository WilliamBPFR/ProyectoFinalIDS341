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

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            var CreateUser = new CreateUser();
            CreateUser.Show();
            Hide();
        }
    }
}