namespace WinFormsApp
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
            label1 = new Label();
            lblProgress = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.Teal;
            progressBar1.Location = new Point(0, 30);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 29);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(271, 5);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 1;
            label1.Text = "Caricamento in corso: ";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lblProgress.ForeColor = SystemColors.ControlLightLight;
            lblProgress.Location = new Point(445, 5);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(33, 21);
            lblProgress.TabIndex = 2;
            lblProgress.Text = "0%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 59);
            Controls.Add(lblProgress);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            ForeColor = SystemColors.ControlText;
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
        private Label label1;
        private Label lblProgress;
        private System.Windows.Forms.Timer timer1;
    }
}