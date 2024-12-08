namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //For the enter button in the login page
        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            // Replace this with your actual authentication logic
            if (username == "your_username" && password == "your_password")
            {
                // Successful login
                MessageBox.Show("Login successful!");
                // You can navigate to another form or perform other actions here
            }
            else
            {
                // Failed login
                MessageBox.Show("Login unsucessful!");
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
