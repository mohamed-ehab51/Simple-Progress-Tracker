namespace Progress_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
            circularProgressBar1.Maximum = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tot = Int32.Parse(total.Text);
                int curr = Int32.Parse(current.Text);
                circularProgressBar1.Value = curr;
                circularProgressBar1.Maximum = tot;
                circularProgressBar1.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the values");
            }
        }
    }
}