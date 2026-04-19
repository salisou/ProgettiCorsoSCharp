namespace CRMScuola.Forms
{
    partial class frmCorso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            picSvuota = new PictureBox();
            btnElimina = new Button();
            btnModifica = new Button();
            btnSalva = new Button();
            label3 = new Label();
            txtDescrizione = new TextBox();
            cbNome = new ComboBox();
            label2 = new Label();
            ddgLista = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSvuota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddgLista).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 38);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(269, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 32);
            label1.TabIndex = 1;
            label1.Text = "Monitoraggio dei Corsi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WinFormsApp.Properties.Resources.close;
            pictureBox1.Location = new Point(948, 5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(picSvuota);
            groupBox1.Controls.Add(btnElimina);
            groupBox1.Controls.Add(btnModifica);
            groupBox1.Controls.Add(btnSalva);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescrizione);
            groupBox1.Controls.Add(cbNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.WindowText;
            groupBox1.Location = new Point(21, 44);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(945, 152);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrazione del corso";
            // 
            // picSvuota
            // 
            picSvuota.Image = WinFormsApp.Properties.Resources.clean;
            picSvuota.Location = new Point(902, 42);
            picSvuota.Margin = new Padding(3, 2, 3, 2);
            picSvuota.Name = "picSvuota";
            picSvuota.Size = new Size(24, 25);
            picSvuota.SizeMode = PictureBoxSizeMode.Zoom;
            picSvuota.TabIndex = 7;
            picSvuota.TabStop = false;
            picSvuota.Click += picSvuota_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(368, 117);
            btnElimina.Margin = new Padding(3, 2, 3, 2);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(136, 28);
            btnElimina.TabIndex = 6;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(204, 118);
            btnModifica.Margin = new Padding(3, 2, 3, 2);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(136, 28);
            btnModifica.TabIndex = 5;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(29, 118);
            btnSalva.Margin = new Padding(3, 2, 3, 2);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(136, 28);
            btnSalva.TabIndex = 4;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(414, 22);
            label3.Name = "label3";
            label3.Size = new Size(140, 19);
            label3.TabIndex = 3;
            label3.Text = "Descrizione del Corso";
            // 
            // txtDescrizione
            // 
            txtDescrizione.Location = new Point(414, 42);
            txtDescrizione.Margin = new Padding(3, 2, 3, 2);
            txtDescrizione.Name = "txtDescrizione";
            txtDescrizione.Size = new Size(475, 29);
            txtDescrizione.TabIndex = 2;
            // 
            // cbNome
            // 
            cbNome.FormattingEnabled = true;
            cbNome.Location = new Point(27, 42);
            cbNome.Margin = new Padding(3, 2, 3, 2);
            cbNome.Name = "cbNome";
            cbNome.Size = new Size(374, 29);
            cbNome.TabIndex = 1;
            cbNome.SelectedIndexChanged += cbNome_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(27, 22);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 0;
            label2.Text = "Nome del Corso";
            // 
            // ddgLista
            // 
            ddgLista.BorderStyle = BorderStyle.None;
            ddgLista.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ddgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ddgLista.Location = new Point(19, 213);
            ddgLista.Margin = new Padding(3, 2, 3, 2);
            ddgLista.Name = "ddgLista";
            ddgLista.RowHeadersWidth = 51;
            ddgLista.Size = new Size(947, 236);
            ddgLista.TabIndex = 3;
            ddgLista.CellClick += ddgLista_CellClick;
            // 
            // frmCorso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(989, 466);
            Controls.Add(ddgLista);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCorso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCorso";
            Load += frmCorso_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSvuota).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddgLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox txtDescrizione;
        private ComboBox cbNome;
        private PictureBox picSvuota;
        private Button btnElimina;
        private Button btnModifica;
        private Button btnSalva;
        private DataGridView ddgLista;
    }
}