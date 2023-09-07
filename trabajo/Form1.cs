namespace trabajo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void TRES_Click(object sender, EventArgs e)
        {
            //BOTON SALIR
            this.Close(); 
        }

        private void uno_Click(object sender, EventArgs e)
        {
            Form2 prueba = new Form2();
            prueba.Show();
        }
    }
}