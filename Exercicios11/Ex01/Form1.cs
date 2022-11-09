namespace aula2610_forms
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserirLista();
        }

        List<string> nomes = new List<string>();
        private void inserirLista()
        {
            Nomes n = new Nomes();
            n.Nome = txtNome.Text.ToUpper();

            string[] verificaNomes;
            verificaNomes = n.Nome.Split(' ');
            if (verificaNomes.Length < 2)
            {
                MessageBox.Show("Insira o nome completo!", "ERRO");
            }
            else if (nomes.Contains(n.Nome))
            {
                MessageBox.Show("Nome já inserido!", "ERRO");
            }
            else
            {
                txtLista.Text = String.Empty;
                nomes.Add(n.Nome);
                nomes.Sort();
                foreach (string item in nomes)
                {
                    txtLista.Text += item + Environment.NewLine;
                }
                txtNome.Text = String.Empty;
            }
            txtNome.Focus();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                inserirLista();
            }
        }
    }
}