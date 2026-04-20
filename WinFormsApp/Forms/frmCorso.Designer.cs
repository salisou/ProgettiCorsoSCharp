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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            picSvuota = new PictureBox();
            btnElimina = new Button();
            btnModifica = new Button();
            btnSalva = new Button();
            label3 = new Label();
            txtDescrizione = new TextBox();
            cbNome = new ComboBox();
            label2 = new Label();
            ddgLista = new DataGridView();
            label4 = new Label();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSvuota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddgLista).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
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
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
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
            groupBox1.Location = new Point(206, 52);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(762, 305);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrazione del corso";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(516, 29);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 29);
            textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 142);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 8;
            label5.Text = "Data inizio ";
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
            btnElimina.Location = new Point(364, 258);
            btnElimina.Margin = new Padding(3, 2, 3, 2);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(136, 28);
            btnElimina.TabIndex = 6;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(200, 259);
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
            btnSalva.Location = new Point(25, 259);
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
            label3.Location = new Point(27, 78);
            label3.Name = "label3";
            label3.Size = new Size(140, 19);
            label3.TabIndex = 3;
            label3.Text = "Descrizione del Corso";
            // 
            // txtDescrizione
            // 
            txtDescrizione.Location = new Point(27, 98);
            txtDescrizione.Margin = new Padding(3, 2, 3, 2);
            txtDescrizione.Name = "txtDescrizione";
            txtDescrizione.Size = new Size(516, 29);
            txtDescrizione.TabIndex = 2;
            // 
            // cbNome
            // 
            cbNome.FormattingEnabled = true;
            cbNome.Location = new Point(27, 42);
            cbNome.Margin = new Padding(3, 2, 3, 2);
            cbNome.Name = "cbNome";
            cbNome.Size = new Size(516, 29);
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
            ddgLista.Location = new Point(23, 361);
            ddgLista.Margin = new Padding(3, 2, 3, 2);
            ddgLista.Name = "ddgLista";
            ddgLista.RowHeadersWidth = 51;
            ddgLista.Size = new Size(947, 236);
            ddgLista.TabIndex = 3;
            ddgLista.CellClick += ddgLista_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(41, 62);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Location = new Point(23, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(177, 313);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo di salvataggio del corso";
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(11, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 117);
            panel2.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(18, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Personalizzazione";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(18, 68);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Predefinito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmCorso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(989, 608);
            Controls.Add(groupBox2);
            Controls.Add(label4);
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
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label4;
        private GroupBox groupBox2;
        private Panel panel2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}