namespace CRMScuola.Forms
{
    partial class frmMain
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
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            picCorso = new PictureBox();
            picStudenti = new PictureBox();
            picVoto = new PictureBox();
            picDocenti = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCorso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDocenti).BeginInit();
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
            panel1.Size = new Size(1004, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(391, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 1;
            label1.Text = "CRM Scuola";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WinFormsApp.Properties.Resources.close;
            pictureBox1.Location = new Point(970, 5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 38);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1004, 463);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(picCorso, 0, 0);
            tableLayoutPanel1.Controls.Add(picStudenti, 1, 0);
            tableLayoutPanel1.Controls.Add(picVoto, 0, 1);
            tableLayoutPanel1.Controls.Add(picDocenti, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1004, 463);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // picCorso
            // 
            picCorso.BackColor = Color.White;
            picCorso.Image = WinFormsApp.Properties.Resources.education;
            picCorso.Location = new Point(3, 2);
            picCorso.Margin = new Padding(3, 2, 3, 2);
            picCorso.Name = "picCorso";
            picCorso.Size = new Size(496, 227);
            picCorso.SizeMode = PictureBoxSizeMode.Zoom;
            picCorso.TabIndex = 0;
            picCorso.TabStop = false;
            picCorso.Click += picCorso_Click;
            // 
            // picStudenti
            // 
            picStudenti.BackColor = Color.White;
            picStudenti.Dock = DockStyle.Fill;
            picStudenti.Image = WinFormsApp.Properties.Resources.studenti;
            picStudenti.Location = new Point(505, 2);
            picStudenti.Margin = new Padding(3, 2, 3, 2);
            picStudenti.Name = "picStudenti";
            picStudenti.Size = new Size(496, 227);
            picStudenti.SizeMode = PictureBoxSizeMode.Zoom;
            picStudenti.TabIndex = 1;
            picStudenti.TabStop = false;
            picStudenti.Click += picStudenti_Click;
            // 
            // picVoto
            // 
            picVoto.BackColor = Color.White;
            picVoto.Dock = DockStyle.Fill;
            picVoto.Image = WinFormsApp.Properties.Resources.maths;
            picVoto.Location = new Point(3, 233);
            picVoto.Margin = new Padding(3, 2, 3, 2);
            picVoto.Name = "picVoto";
            picVoto.Size = new Size(496, 228);
            picVoto.SizeMode = PictureBoxSizeMode.Zoom;
            picVoto.TabIndex = 2;
            picVoto.TabStop = false;
            picVoto.Click += picVoto_Click;
            // 
            // picDocenti
            // 
            picDocenti.BackColor = Color.White;
            picDocenti.Dock = DockStyle.Fill;
            picDocenti.Image = WinFormsApp.Properties.Resources.teacher;
            picDocenti.Location = new Point(505, 233);
            picDocenti.Margin = new Padding(3, 2, 3, 2);
            picDocenti.Name = "picDocenti";
            picDocenti.Size = new Size(496, 228);
            picDocenti.SizeMode = PictureBoxSizeMode.Zoom;
            picDocenti.TabIndex = 3;
            picDocenti.TabStop = false;
            picDocenti.Click += picDocenti_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 501);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCorso).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDocenti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox picCorso;
        private PictureBox picStudenti;
        private PictureBox picVoto;
        private PictureBox picDocenti;
        private Label label1;
    }
}