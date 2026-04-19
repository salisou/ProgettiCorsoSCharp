namespace CRMScuola.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void picCorso_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCorso corso = new();
            corso.Show();
        }

        private void picStudenti_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudenti studenti = new();
            studenti.Show();
        }

        private void picVoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVoto voto = new();
            voto.Show();
        }

        private void picDocenti_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocenti docenti = new();
            docenti.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMain main = new();
            main.Show();
            this.Close();
        }
    }
}
