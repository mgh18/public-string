namespace Public_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                if(textBox1.Text == "admin" && textBox2.Text == "1")
                {
                    Form2 f2 = new Form2();
                    Program.username = textBox1.Text;
                    this.Hide();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }
            }
        }
    }
}