namespace Desafio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            if (banco.User == textBoxLogin.Text && banco.Password == textBoxSenha.Text)
            {
                MessageBox.Show("Login efetuado com sucesso!", "Usuário autenticado");
                ClienteForm cf = new ClienteForm();
                this.Hide();
                cf.Show();
            }
            else
            {
                MessageBox.Show("Login e/ou senha incorreto", "ERRO!");
            }
        }

        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void textBoxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

    }
}