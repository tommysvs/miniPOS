namespace miniPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Container container = new Container();
            container.Show();
            this.Hide();
        }
    }
}
