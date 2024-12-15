using static System.Formats.Asn1.AsnWriter;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        List<int> pastPurchases = new List<int> { };
        List<int> cart = new List<int> { };
        string currentUser = "";

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
                // Jin - added in Form 2 to show form 2
                Form2 form2 = new Form2();
                form2.Show();
            }

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private static Boolean Login(string username, string password)
        {
            bool found = false;
            string filePath = "../../../Data.txt";

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
                                var pastPurchases = parts[2].Split(',');
                                var cart = parts[3].Split(',');
                                MessageBox.Show("Login successful!");
                                string currentUser = username;
                                return true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("No login found.");
                            MessageBox.Show("Login unsuccessful!");
                            return false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading login: {ex.Message}");
            }
            return false;
        }

        private static void Save(string username, List<Product> cart, List<Product> pastPurchases)
        {
            bool found = false;
            string filePath = "../../../Data.txt";

            String[] storedCartArray = new String[cart.Count]; //will hold the multiple ToString of products
            String[] pastPurchaseArray = new String[pastPurchases.Count]; //will hold the multiple ToString of past purchases

            // Read all entries into a list
            var entries = new List<string>();
            if (File.Exists(filePath))
            {
                entries = File.ReadAllLines(filePath).ToList();
            }

            // Check if the username already exists
            for (int i = 0; i < entries.Count; i++)
            {
                var parts = entries[i].Split('|');
                if (parts[0].Equals(username) && !found)
                {
                    //iterate through both list and assign them to arrays to be stored, breaking them into parts
                    //Convert from product to array to string for saving and then reverse when pulling
                    //doesn't account for duplicates yet.
                    foreach (Product item in cart)
                    {
                        storedCartArray[cart.IndexOf(item)] = (item.ToString());
                    }
                    foreach (Product item in pastPurchases)
                    {
                        storedCartArray[pastPurchases.IndexOf(item)] = (item.ToString());
                    }

                    // Update the data for current user
                    entries[i] = ($"{username}|{parts[1]}|{String.Join(',',pastPurchases)}|{String.Join(',',storedCartArray)}");
                                    //user, password, pastpurchases separated by commas, cart separated by commas
                    found = true;//stop searching once it is found
                    Console.WriteLine($"Data saved under {username}");
                }
            }
            if (!found) Console.WriteLine("Error"); //if something messed up and no user is found, declare that.
            File.WriteAllLines(filePath, entries);
        }
        private static void CreateAccount(string username, string password)
        {
            string filePath = "../../../Data.txt";
            // Read all entries into a list
            var entries = new List<string>();
            entries = File.ReadAllLines(filePath).ToList();
            entries.Add($"{username}|{password}||");
            File.WriteAllLines(filePath, entries);
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
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            CreateAccount(username, password);
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
