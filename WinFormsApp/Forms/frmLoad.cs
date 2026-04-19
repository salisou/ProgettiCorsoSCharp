namespace CRMScuola.Forms
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                lblPrograss.Text = progressBar1.Value.ToString();
            }
            else
            {
                timer1.Stop();
                this.Hide();
                frmMain mainForm = new();
                mainForm.ShowDialog();
            }
        }
    }
}
