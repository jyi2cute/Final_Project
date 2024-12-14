using static System.Formats.Asn1.AsnWriter;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        List<int> pastPurchases = new List<int> { };
        List<int> cart = new List<int> { };

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;


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
            if (Login(username, password))
            {
                MessageBox.Show("Login successful!");
            }
            else MessageBox.Show("Login unsuccessful!");

            // Jin - added in Form 2 to show form 2
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private static bool Login(string username, string password)
        {
            bool found = false;
            string filePath = "Data.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split('|');

                            if (parts[0] == username && parts[1] == password)
                            {
                                found = true;
                                Console.WriteLine($"Found login for {username}: {parts[1]}");
                                //pastPurchases.Add(parts[2].ToList());
                                //cart.Add(parts[3].ToList());
                                return true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("No login found.");
                            return false;
                        }

                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading login: {ex.Message}");
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Jin - added in create account button to go to form 2
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
