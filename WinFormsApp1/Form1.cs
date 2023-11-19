namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buApply_Click(object sender, EventArgs e)
        {
            String firstName = edFirstName.Text;
            String lastName = edLastName.Text;
            tvWelcome.Text = $"Hello {firstName} {lastName}";
        }

        private void buClear_Click(object sender, EventArgs e)
        {
            edFirstName.Text = "";
            edLastName.Text = "";
            tvWelcome.Text = "";
        }
    }
}
