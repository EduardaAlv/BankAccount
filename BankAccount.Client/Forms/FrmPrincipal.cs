using BankAccount.Forms;

namespace BankAccount
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void criarContaBanc�riaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Remove controles anteriores (se houver)
            panelConteudo.Controls.Clear();

            // Cria uma inst�ncia do UserControl
            CreateAccount criarConta = new CreateAccount();

            // Ajusta tamanho e dock para preencher o painel
            criarConta.Dock = DockStyle.Fill;

            // Adiciona o UserControl ao painel
            panelConteudo.Controls.Add(criarConta);
        }

        private void verContasBanc�riasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Remove controles anteriores (se houver)
            panelConteudo.Controls.Clear();

            // Cria uma inst�ncia do UserControl
            GridAccountBank gridAccountBank = new GridAccountBank();

            // Ajusta tamanho e dock para preencher o painel
            gridAccountBank.Dock = DockStyle.Fill;

            // Adiciona o UserControl ao painel
            panelConteudo.Controls.Add(gridAccountBank);
        }

        private void creditsMenuToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // Remove controles anteriores (se houver)
            panelConteudo.Controls.Clear();

            // Cria uma inst�ncia do UserControl
            Credits credits = new Credits();

            // Ajusta tamanho e dock para preencher o painel
            credits.Dock = DockStyle.Fill;

            // Adiciona o UserControl ao painel
            panelConteudo.Controls.Add(credits);

        }
    }
}
