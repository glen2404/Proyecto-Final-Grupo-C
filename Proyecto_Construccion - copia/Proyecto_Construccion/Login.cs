using CapaVisual;

namespace Proyecto_Construccion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarUsuario f2 = new RegistrarUsuario();
            f2.Show();
            
        }
    }
}
