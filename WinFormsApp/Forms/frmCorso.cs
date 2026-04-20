using CRMScuola.Data.Database;
using System.Text.Json;
using WinFormsApp.Models;

namespace CRMScuola.Forms
{
    public partial class frmCorso : Form
    {
        // Variabile globale
        private List<Corsi> listaCorsi = new();
        private readonly CorsiRepository repo = new();
        private int corsoSelezionatoId = 0;

        public frmCorso()
        {
            InitializeComponent();
            cbNome.SelectedIndexChanged += cbNome_SelectedIndexChanged;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMain main = new();
            main.Show();
            this.Close();
        }

        private void ConfiguraGrid()
        {
            ddgLista.DefaultCellStyle.ForeColor = Color.Black;
            ddgLista.DefaultCellStyle.SelectionForeColor = Color.Black;

            ddgLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ddgLista.RowHeadersVisible = false;
            ddgLista.AllowUserToAddRows = false;
            ddgLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ddgLista.MultiSelect = false;
            ddgLista.ReadOnly = true;
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            Corsi nuovo = new()
            {
                NomeCorso = cbNome.Text,
                Descrizione = txtDescrizione.Text
            };

            repo.Insert(nuovo);

            MessageBox.Show("Corso salvato su SQLite!");

            CaricaGrid();
        }

        private void CaricaGrid()
        {
            ddgLista.DataSource = repo.GetAll();
        }

        private void SalvaJson()
        {
            string path = @"D:\CorsoCSharp\CRMScuola\Data\corsi.json";

            List<Corsi> corsi = new();

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                corsi = JsonSerializer.Deserialize<List<Corsi>>(json) ?? new();
            }
            else
            {
                //File.WriteAllText(path, );
                File.Create(path);
            }

            Corsi nuovoCorso = new()
            {
                CorsoId = corsi.Count > 0 ? corsi.Max(c => c.CorsoId) + 1 : 1,
                NomeCorso = cbNome.Text,
                Descrizione = txtDescrizione.Text
            };

            corsi.Add(nuovoCorso);

            string nuovoJson = JsonSerializer.Serialize(corsi, new JsonSerializerOptions
            {
                WriteIndented = true,
            });

            File.WriteAllText(path, nuovoJson);

            MessageBox.Show("Corso salvato!");

            CaricamentoCombo();
        }

        private void frmCorso_Load(object sender, EventArgs e)
        {
            ConfiguraGrid();
            CaricamentoCombo();
            CaricaGrid();

            if (radioButton1.Checked == true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            else {
                cbNome.Visible = false;
                txtDescrizione.Visible = false;
            }
        }

        public void CaricamentoCombo()
        {

            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "listaCorsi.json");
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                , "listaCorsi.json");

            //string sim = "C:\\Corso C#\\Esercizi\\WinFormLast\\WinFormApp-2026-master\\CRMScuola\\Data\\corsi.json";
            //string path = @"D:\CorsoCSharp\CRMScuola\Data\listaCorsi.json";

            if (!File.Exists(path))
            {
                MessageBox.Show("File listaCorsi.json non trovato!");
                return;
            }

            string json = File.ReadAllText(path);
            listaCorsi = JsonSerializer.Deserialize<List<Corsi>>(json) ?? new();

            cbNome.DataSource = listaCorsi.Select(c => c.NomeCorso).ToList();

            //cbNome.DataSource = null; // importante per refresh corretto
            //cbNome.DataSource = corsi;  

            //cbNome.DisplayMember = nameof(Corsi.NomeCorso); 
            //cbNome.ValueMember = nameof(Corsi.CorsoId); 
        }


        // POPOLARE txtDescrizione QUANDO CAMBIA IL COMBOBOX
        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = cbNome.SelectedItem?.ToString() ?? "";

            var corso = listaCorsi.FirstOrDefault(c => c.NomeCorso == nome);

            if (corso != null)
            {
                txtDescrizione.Text = corso.Descrizione;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (corsoSelezionatoId == 0)
            {
                MessageBox.Show("Seleziona un corso dalla lista!");
                return;
            }

            Corsi corso = new()
            {
                CorsoId = corsoSelezionatoId,
                NomeCorso = cbNome.Text,
                Descrizione = txtDescrizione.Text
            };

            repo.Update(corso);

            MessageBox.Show("Corso aggiornato!");

            CaricaGrid();
        }

        private void ddgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ddgLista.Rows[e.RowIndex];

                corsoSelezionatoId = Convert.ToInt32(row.Cells["CorsoId"].Value);
                cbNome.Text = row.Cells["NomeCorso"].Value.ToString();
                txtDescrizione.Text = row.Cells["Descrizione"].Value.ToString();
            }
        }

        private void picSvuota_Click(object sender, EventArgs e)
        {
            cbNome.SelectedIndex = -1;
            txtDescrizione.Clear();

            corsoSelezionatoId = 0;

            ddgLista.ClearSelection();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmMain main = new();
            main.Show();
            this.Close();
        }
    }
}
