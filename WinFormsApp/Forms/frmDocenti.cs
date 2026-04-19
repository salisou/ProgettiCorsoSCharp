using CRMScuola.Data.Database;
using WinFormsApp.Data.Database;
using WinFormsApp.Models;

namespace CRMScuola.Forms
{
    public partial class frmDocenti : Form
    {
        CorsiRepository repoCorsi = new();
        DocentiRepository repoDocenti = new();

        public frmDocenti()
        {
            InitializeComponent();
        }

        private void frmDocenti_Load(object sender, EventArgs e)
        {
            CaricaCorsi();
            CaricaDocenti();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMain main = new();
            main.Show();
            this.Close();
        }

        // =========================
        // CARICA CORSI
        // =========================
        private void CaricaCorsi()
        {
            var corsi = repoCorsi.GetAll();

            cbCorso.DataSource = null;
            cbCorso.DataSource = corsi;
            cbCorso.DisplayMember = "NomeCorso";
            cbCorso.ValueMember = "CorsoId";
        }

        // =========================
        // CARICA DOCENTI
        // =========================
        private void CaricaDocenti()
        {
            var lista = repoDocenti.GetAll();

            ddgListaDocenti.DataSource = null;
            ddgListaDocenti.DataSource = lista;
        }

        // =========================
        // CREATE
        // =========================
        private void picAdd_Click(object sender, EventArgs e)
        {
            var docente = new Docenti
            {
                Nome = txtNome.Text,
                Cognome = txtCognome.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                CorsoId = (int)cbCorso.SelectedValue
            };

            repoDocenti.Insert(docente);

            MessageBox.Show("Docente salvato!");
            CaricaDocenti();
        }

        // =========================
        // UPDATE
        // =========================
        private void picUpdate_Click(object sender, EventArgs e)
        {
            if (ddgListaDocenti.CurrentRow?.DataBoundItem is Docenti docente)
            {
                docente.Nome = txtNome.Text;
                docente.Cognome = txtCognome.Text;
                docente.Email = txtEmail.Text;
                docente.Telefono = txtTelefono.Text;
                docente.CorsoId = (int)cbCorso.SelectedValue;

                repoDocenti.Update(docente);

                MessageBox.Show("Docente aggiornato!");
                CaricaDocenti();
            }
        }

        // =========================
        // DELETE
        // =========================
        private void pictDelete_Click(object sender, EventArgs e)
        {
            if (ddgListaDocenti.CurrentRow?.DataBoundItem is Docenti docente)
            {
                repoDocenti.Delete(docente.DocenteId);

                MessageBox.Show("Docente eliminato!");
                CaricaDocenti();
            }
        }

        // =========================
        // CLICK GRID → RIEMPI CAMPI
        // =========================
        private void ddgListaDocenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ddgListaDocenti.CurrentRow?.DataBoundItem is Docenti docente)
            {
                txtNome.Text = docente.Nome;
                txtCognome.Text = docente.Cognome;
                txtEmail.Text = docente.Email;
                txtTelefono.Text = docente.Telefono;

                cbCorso.SelectedValue = docente.CorsoId;
            }
        }
    }
}
