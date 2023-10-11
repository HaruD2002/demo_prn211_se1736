namespace WinFormsApp
{
    public partial class body : Form
    {
        public body()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btn_asa
            //event handler
            MessageBox.Show("hello from asa", "alert", MessageBoxButtons.OKCancel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello from ban", "warning", MessageBoxButtons.YesNo);
        }

        private void btn_miru_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello from miru", "trang cute", MessageBoxButtons.YesNoCancel);
        }
    }
}