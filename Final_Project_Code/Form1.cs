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
            login(username, password);
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

        private static void login(string username, string password)
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
                            var parts = line.Split(',');

                            if (parts[0] == username && parts[1] == password)
                            {
                                found = true;
                                Console.WriteLine($"Found login for {username}: {parts[1]}");
                                pastPurchases = parts[2];
                                cart = parts[3];
                            }
                        }
                        if (!found) Console.WriteLine("No login found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading login: {ex.Message}");
            }
        }
    }
}
