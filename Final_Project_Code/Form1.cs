using System.ComponentModel;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        //List<int> pastPurchases = new List<int> { };
        //List<int> cart = new List<int> { };
        public string currentUser = "";
        public List<Product> pastPurchases = new List<Product>(); // will append cart to this
        public List<Rating> oldRatings = new List<Rating>(); //used for rating in Load function
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            instance = this;
            currentUser = currentUser;
            pastPurchases = pastPurchases;
        }
        //username label - login page
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //password label - login page
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Jin - Storefront title
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

        //All account functions (Login, register, save and load data, change password in form2, lead Yuri, adjustments by others to
        //better implement with rest of )
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
                                Form1.instance.currentUser = parts[0];
                                string[] loadedPurchases = parts[2].Split('*') ;

                                //iterate through this array and add these values to loaded purchases
                                //if this isn't empty
                                if (loadedPurchases.Length > 1)
                                {
                                    foreach (string purchaseLine in loadedPurchases)
                                    {
                                        string[] purchase = purchaseLine.Split(",") ;
                                        //"{Name},{Price},{Category},{Ratings},{ShippingTime}"
                                        //ratings being their own List
                                        string name = purchase[0].ToString();
                                        decimal price = Convert.ToDecimal(purchase[1].ToString());
                                        string category = purchase[2].ToString();

                                        //$"{Stars},{Comment},{Username}";
                                        //because rating is a List of ratings, we must split this section by ~ then each part by :
                                        string[] ratingLines = purchase[3].ToString().Split('~');
                                        foreach (string rating in ratingLines)
                                        {
                                            string[] ratingParts = rating.ToString().Split(':');
                                                //(ratingStars, ratingComment, ratingUser);
                                                int ratingStars = int.Parse(ratingParts[0].ToString());
                                                string ratingComment = ratingParts[1].ToString();
                                                string ratingUser = ratingParts[2].ToString();
                                                Rating oldRate = new Rating(ratingStars, ratingComment, ratingUser);// one line for rating
                                                Form1.instance.oldRatings.Add(oldRate);
                                        }

                                        string shippingTime = purchase[4].ToString();
                                        Product tempPurchase = new Product(name, price, category, Form1.instance.oldRatings, shippingTime);
                                        Form1.instance.pastPurchases.Add(tempPurchase);
                                    }
                                }

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

        //createAccount function - 
        private static void CreateAccount(string username, string password)
        {
            string filePath = "../../../Data.txt";
            // Read all entries into a list
            var entries = new List<string>();
            entries = File.ReadAllLines(filePath).ToList();
            entries.Add($"{username}|{password}||");
            File.WriteAllLines(filePath, entries);
        }


        //Jin - Link label to the sign up page
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
        }

        //Jin: panel 2 - Sign up page
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

        //Jin - added in a back button to login page
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

       
    }
}
