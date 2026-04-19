namespace CRMScuola.Forms
{
    partial class frmLoad
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            lblPrograss = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 37);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 37);
            progressBar1.TabIndex = 0;
            // 
            // lblPrograss
            // 
            lblPrograss.AutoSize = true;
            lblPrograss.ForeColor = Color.White;
            lblPrograss.Location = new Point(454, 9);
            lblPrograss.Name = "lblPrograss";
            lblPrograss.Size = new Size(17, 20);
            lblPrograss.TabIndex = 1;
            lblPrograss.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(292, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 2;
            label2.Text = "Caricamento in corso: ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmLoad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 74);
            Controls.Add(label2);
            Controls.Add(lblPrograss);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoad";
            Load += frmLoad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblPrograss;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}