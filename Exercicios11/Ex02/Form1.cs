namespace Lista11_Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarEmail();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                cadastrarEmail();
            }
        }

        List<string> emails = new List<string>();
        List<string> dominios = new List<string>();
        private void cadastrarEmail()
        {
            EmailClass e = new EmailClass();
            e.Email = txtNome.Text.ToUpper();
            string[] pegaDominio;
            if (emails.Contains(e.Email))
            {
                MessageBox.Show("E-mail já inserido", "ERRO");
            }else if (String.IsNullOrWhiteSpace(e.Email))
            {
                MessageBox.Show("Insira um e-mail", "ERRO");
            }
            else
            {
                pegaDominio = e.Email.Split("@");
                dominios.Add(pegaDominio[1]);
                emails.Add(e.Email);
            }
            txtNome.Text = String.Empty;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = String.Empty;
            emails.Sort();
            foreach(string x in emails)
            {
                txtLista.Text += x + Environment.NewLine;
            }

            txtDominios.Text = String.Empty;
            dominios = dominios.Distinct().ToList();
            dominios.Sort();
            foreach (string x in dominios)
            {
                txtDominios.Text += x + Environment.NewLine;
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            emails.Clear();
            dominios.Clear();
            txtLista.Text = String.Empty;
            txtDominios.Text = String.Empty;
        }
    }
}