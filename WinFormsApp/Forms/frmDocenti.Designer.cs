namespace CRMScuola.Forms
{
    partial class frmDocenti
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
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictDelete = new PictureBox();
            picUpdate = new PictureBox();
            picAdd = new PictureBox();
            cbCorso = new ComboBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtCognome = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            ddgListaDocenti = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddgListaDocenti).BeginInit();
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
            panel1.Size = new Size(988, 38);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(382, 0);
            label1.Name = "label1";
            label1.Size = new Size(291, 32);
            label1.TabIndex = 1;
            label1.Text = "Gestione Docenti";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WinFormsApp.Properties.Resources.close;
            pictureBox1.Location = new Point(956, 6);
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
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 424);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = WinFormsApp.Properties.Resources.teacher;
            pictureBox2.Location = new Point(3, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 167);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cbCorso);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCognome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(176, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 187);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Monitoraggio";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictDelete);
            groupBox2.Controls.Add(picUpdate);
            groupBox2.Controls.Add(picAdd);
            groupBox2.Location = new Point(461, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 51);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // pictDelete
            // 
            pictDelete.Image = WinFormsApp.Properties.Resources.delete;
            pictDelete.Location = new Point(207, 17);
            pictDelete.Name = "pictDelete";
            pictDelete.Size = new Size(35, 23);
            pictDelete.SizeMode = PictureBoxSizeMode.Zoom;
            pictDelete.TabIndex = 15;
            pictDelete.TabStop = false;
            pictDelete.Click += pictDelete_Click;
            // 
            // picUpdate
            // 
            picUpdate.Image = WinFormsApp.Properties.Resources.edit;
            picUpdate.Location = new Point(142, 18);
            picUpdate.Name = "picUpdate";
            picUpdate.Size = new Size(35, 22);
            picUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            picUpdate.TabIndex = 14;
            picUpdate.TabStop = false;
            picUpdate.Click += picUpdate_Click;
            // 
            // picAdd
            // 
            picAdd.Image = WinFormsApp.Properties.Resources.add;
            picAdd.Location = new Point(79, 18);
            picAdd.Name = "picAdd";
            picAdd.Size = new Size(31, 22);
            picAdd.SizeMode = PictureBoxSizeMode.Zoom;
            picAdd.TabIndex = 13;
            picAdd.TabStop = false;
            picAdd.Click += picAdd_Click;
            // 
            // cbCorso
            // 
            cbCorso.FormattingEnabled = true;
            cbCorso.Location = new Point(27, 147);
            cbCorso.Name = "cbCorso";
            cbCorso.Size = new Size(333, 23);
            cbCorso.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 129);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 8;
            label6.Text = "Corso";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(462, 92);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(309, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 74);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 6;
            label5.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 23);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 74);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(462, 37);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(309, 23);
            txtCognome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 19);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Cognome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(335, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 19);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ddgListaDocenti);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(176, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(805, 219);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista dei Docenti";
            // 
            // ddgListaDocenti
            // 
            ddgListaDocenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ddgListaDocenti.Location = new Point(9, 17);
            ddgListaDocenti.Name = "ddgListaDocenti";
            ddgListaDocenti.Size = new Size(787, 194);
            ddgListaDocenti.TabIndex = 5;
            // 
            // frmDocenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(988, 462);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDocenti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDocenti";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ddgListaDocenti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCognome;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private ComboBox cbCorso;
        private Label label6;
        private GroupBox groupBox2;
        private PictureBox pictDelete;
        private PictureBox picUpdate;
        private PictureBox picAdd;
        private GroupBox groupBox3;
        private DataGridView ddgListaDocenti;
        private PictureBox pictureBox2;
    }
}