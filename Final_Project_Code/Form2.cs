using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Project
{

    public partial class Form2 : Form
    {
        //Create the lists for all the products and the cart - Dessa
        private List<Product> products = new List<Product>();
        private List<Product> cart = new List<Product>();
        private TextBox oldPasswordBox;
        private TextBox newPasswordBox;
        private TextBox confirmPasswordBox;
        private Panel changePasswordPanel;
        public static Form2 instance;

        // Dessa Created function 
        private void InitializeStore()
        {
            //these are all the items 
            products.Add(new Product("Comforter Set", 49.99m, "Comfort", new List<Rating> {
                new Rating(5, "Super comfy!", "Alice"),
                new Rating(4, "Good value.", "Bob")
            }, "2 days"));

            products.Add(new Product("Bluetooth Headphones", 89.99m, "Electronics", new List<Rating> {
                new Rating(5, "Great sound quality!", "Charlie"),
                new Rating(4, "Battery life could be better.", "Dana")
            }, "3 days"));

            products.Add(new Product("Pizza Pack", 15.99m, "Food", new List<Rating> {
                new Rating(4, "Tastes great!", "Eve")
            }, "1 day"));

            products.Add(new Product("Smartwatch", 129.99m, "Electronics", new List<Rating> {
                new Rating(5, "Very convenient!", "Frank"),
                new Rating(5, "Love it!", "Grace")
            }, "3 days"));

            products.Add(new Product("Plush Throw Blanket", 19.99m, "Comfort", new List<Rating> {
                new Rating(3, "Too small for me.", "Hank")
            }, "2 days"));

            products.Add(new Product("Inflatable Couch", 39.99m, "Comfort", new List<Rating> {
                new Rating(5, "Perfect for surprise naps!", "Ivy"),
                new Rating(4, "Deflates slowly over time.", "Jack")
            }, "3 days"));

            products.Add(new Product("Neon Cat Lamp", 24.99m, "Electronics", new List<Rating> {
                new Rating(5, "Lights up my soul and my desk!", "Karen"),
                new Rating(2, "Scared my dog at night.", "Larry")
            }, "1 day"));

            products.Add(new Product("Giant Chocolate Bar", 12.99m, "Food", new List<Rating> {
                new Rating(5, "Worth every calorie!", "Mallory"),
                new Rating(4, "Couldn’t finish it in one sitting so sad.", "Nate")
            }, "2 days"));

            products.Add(new Product("Weighted Blanket", 59.99m, "Comfort", new List<Rating> {
                new Rating(5, "Like a hug from the void!", "Olivia"),
                new Rating(3, "Too heavy to lift off the bed.", "Paul")
            }, "4 days"));

            products.Add(new Product("Self-Stirring Mug", 19.99m, "Electronics", new List<Rating> {
                new Rating(4, "Lazy perfection!", "Quinn"),
                new Rating(3, "Doesn’t stir thick soups. Sad.", "Riley")
            }, "2 days"));

            products.Add(new Product("Spicy Noodle Challenge Pack", 9.99m, "Food", new List<Rating> {
                new Rating(5, "Fire in my mouth, fire in my heart!", "Sam"),
                new Rating(2, "Regret is spicy.", "Taylor")
            }, "1 day"));

            products.Add(new Product("Unicorn Slippers", 14.99m, "Comfort", new List<Rating> {
                new Rating(5, "Magical and warm!", "Uma"),
                new Rating(3, "The horn fell off after a week.", "Victor")
            }, "3 days"));

            products.Add(new Product("Portable Mini Fridge", 99.99m, "Electronics", new List<Rating> {
                new Rating(4, "Keeps my soda cold!", "Wendy"),
                new Rating(2, "Doesn’t fit a full watermelon.", "Xander")
            }, "4 days"));

            products.Add(new Product("Mystery Snack Box", 29.99m, "Food", new List<Rating> {
                new Rating(5, "I love surprises!", "Yara"),
                new Rating(1, "Got too many raisins.", "Zane")
            }, "3 days"));

            products.Add(new Product("Body Pillow with Arms", 49.99m, "Comfort", new List<Rating> {
                new Rating(5, "Finally someone to hug me back!", "Alice"),
                new Rating(2, "It’s just a pillow with arms.", "Bob")
            }, "2 days"));

            products.Add(new Product("Bluetooth Toaster", 69.99m, "Electronics", new List<Rating> {
                new Rating(5, "Toasts while I snooze!", "Charlie"),
                new Rating(3, "App crashed while making my toast.", "Dana")
            }, "5 days"));

            products.Add(new Product("Gourmet Pickle Jar", 8.99m, "Food", new List<Rating> {
                new Rating(5, "Pickle perfection!", "Eve"),
                new Rating(4, "Could use more garlic.", "Frank")
            }, "1 day"));

            products.Add(new Product("Cactus Cushion", 21.99m, "Comfort", new List<Rating> {
                new Rating(5, "Looks spiky, feels soft!", "Grace"),
                new Rating(3, "Not as squishy as expected.", "Hank")
            }, "2 days"));

            products.Add(new Product("Smart Fork", 29.99m, "Electronics", new List<Rating> {
                new Rating(4, "Tells me when I eat too fast. Genius!", "Ivy"),
                new Rating(2, "Called me out at dinner. Rude.", "Jack")
            }, "3 days"));

            products.Add(new Product("Cheese Fountain", 44.99m, "Food", new List<Rating> {
                new Rating(5, "It’s a dream come true!", "Karen"),
                new Rating(3, "Cleanup is a nightmare.", "Larry")
            }, "1 day"));

            products.Add(new Product("Glow-in-the-Dark Socks", 12.99m, "Comfort", new List<Rating> {
                new Rating(5, "Perfect for midnight snack runs!", "Mallory"),
                new Rating(3, "They glow too bright for sleeping.", "Nate")
            }, "2 days"));

            products.Add(new Product("Wi-Fi Enabled Toaster", 89.99m, "Electronics", new List<Rating> {
                new Rating(4, "It sends me toast notifications!", "Olivia"),
                new Rating(3, "Too smart for its own good.", "Paul")
            }, "4 days"));

            products.Add(new Product("Extreme Hot Sauce Set", 29.99m, "Food", new List<Rating> {
                new Rating(5, "Heat level: apocalypse!", "Quinn"),
                new Rating(2, "Too hot to handle.", "Riley")
            }, "1 day"));

            products.Add(new Product("Bean Bag Chair", 49.99m, "Comfort", new List<Rating> {
                new Rating(5, "Best nap spot ever!", "Sam"),
                new Rating(3, "Beans spill everywhere.", "Taylor")
            }, "3 days"));

            products.Add(new Product("Holographic Keyboard", 199.99m, "Electronics", new List<Rating> {
                new Rating(5, "Feels like the future!", "Uma"),
                new Rating(4, "Hard to use in bright sunlight.", "Victor")
            }, "5 days"));

            products.Add(new Product("Instant Ramen Pack", 15.99m, "Food", new List<Rating> {
                new Rating(5, "Best for late-night cravings!", "Wendy"),
                new Rating(3, "Too much sodium.", "Xander")
            }, "2 days"));

        }

        // Dessa Created function to display the products
        private void DisplayProducts(string category = "All", string searchQuery = "")
        {
            //flowLayoutPanel1.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(9, 111);
            flowLayoutPanel1.Size = new Size(646, 310);
            //  flowLayoutPanel1.Invalidate();

            if (category == "None")
            {
                flowLayoutPanel1.Visible = false; // Hide the flow panel
                //flowLayoutPanel1.Controls.Clear();
                //flowLayoutPanel1.Invalidate();
                return; // Exit the method early
            }

            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();


            IEnumerable<Product> filteredProducts = products;

            // create a filter by category
            if (category != "All")
            {
                filteredProducts = filteredProducts.Where(p => p.Category == category);
            }

            // create a search by name
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                filteredProducts = filteredProducts.Where(p => p.Name.ToLower().Contains(searchQuery.ToLower()));
            }

            //display all the prodects when filtered
            foreach (var product in filteredProducts)
            {
                var panel = new Panel
                {
                    Size = new Size(200, 100),
                    BorderStyle = BorderStyle.FixedSingle
                };

                var nameLabel = new Label
                {
                    Text = product.Name,
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                var priceLabel = new Label
                {
                    Text = $"Price: ${product.Price:F2}",
                    Location = new Point(10, 30),
                    AutoSize = true
                };

                var ratingLabel = new Label
                {
                    Text = product.Ratings.Any()
                    ? $"Rating: {new string('★', (int)product.Ratings.Average(r => r.Stars))}"
                    : "No ratings yet",
                    Location = new Point(10, 50),
                    AutoSize = true
                };

                var addToCartButton = new Button
                {
                    Text = "Add to Cart",
                    Location = new Point(10, 70),
                    Size = new Size(100, 25)
                };

                addToCartButton.Click += (sender, e) =>
                {
                    cart.Add(product);
                    Save(Form1.instance.currentUser, cart, Form1.instance.pastPurchases);
                    MessageBox.Show($"{product.Name} added to cart!", "Cart Update");
                };

                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(ratingLabel);
                panel.Controls.Add(addToCartButton);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        //Shawn's Modified Display Functions
        private void DisplayCart()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(88, 111);
            flowLayoutPanel1.Size = new Size(487, 193);
            //flowLayoutPanel1.Visible = false;

            //  flowLayoutPanel1.Invalidate();

            if (0 == cart.Count)
            {
                var emptyMessageLabel = new Label
                {
                    Text = "Your cart is empty.",
                    Location = new Point(10, 10),
                    AutoSize = true
                };
                flowLayoutPanel1.Controls.Add(emptyMessageLabel);
                //flowLayoutPanel1.Controls.Clear();
                //flowLayoutPanel1.Invalidate();
                return; // Exit the method early
            }

            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();


            //display all the prodects when filtered
            foreach (var product in cart)
            {
                var panel = new Panel
                {
                    Size = new Size(200, 100),
                    BorderStyle = BorderStyle.FixedSingle
                };

                var nameLabel = new Label
                {
                    Text = product.Name,
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                var priceLabel = new Label
                {
                    Text = $"Price: ${product.Price:F2}",
                    Location = new Point(10, 30),
                    AutoSize = true
                };

                var ratingLabel = new Label
                {
                    Text = product.Ratings.Any()
                    ? $"Rating: {new string('★', (int)product.Ratings.Average(r => r.Stars))}"
                    : "No ratings yet",
                    Location = new Point(10, 50),
                    AutoSize = true
                };

                var removeCartButton = new Button
                {
                    Text = "Remove",
                    Location = new Point(10, 70),
                    Size = new Size(100, 25)

                };

                removeCartButton.Click += (sender, e) =>
                {
                    cart.Remove(product);
                    MessageBox.Show($"{product.Name} Removed from cart!", "Cart Update");
                    DisplayCart();
                };

                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(ratingLabel);
                panel.Controls.Add(removeCartButton);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private void DisplayPastP()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(320, 50);
            flowLayoutPanel1.Size = new Size(210, 380);
            //flowLayoutPanel1.Visible = false;

            //  flowLayoutPanel1.Invalidate();
            if (Form1.instance.pastPurchases.Count == 0)
            {
                var emptyMessageLabel = new Label
                {
                    Text = "No Past Purchases.",
                    Location = new Point(10, 10),
                    AutoSize = true
                };
                flowLayoutPanel1.Controls.Add(emptyMessageLabel);
                //flowLayoutPanel1.Controls.Clear();
                //flowLayoutPanel1.Invalidate();
                return; // Exit the method early
            }

            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();


            //display all the prodects when filtered
            foreach (var product in Form1.instance.pastPurchases)
            {
                var panel = new Panel
                {
                    Size = new Size(200, 100),
                    BorderStyle = BorderStyle.FixedSingle
                };

                var nameLabel = new Label
                {
                    Text = product.Name,
                    Location = new Point(1, 10),
                    AutoSize = true
                };

                var priceLabel = new Label
                {
                    Text = $"Price: ${product.Price:F2}",
                    Location = new Point(10, 30),
                    AutoSize = true
                };

                var ratingLabel = new Label
                {
                    Text = product.Ratings.Any()
                    ? $"Rating: {new string('★', (int)product.Ratings.Average(r => r.Stars))}"
                    : "No ratings yet",
                    Location = new Point(10, 50),
                    AutoSize = true
                };
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(ratingLabel);
                

                flowLayoutPanel1.Controls.Add(panel);
            }
        }


            public Form2()
            {
                InitializeComponent();


                //Tommy- created an account button in the top right of home page
                Button accountButton = new Button
                {
                    Text = "Account",
                    Location = new Point(400, 5),
                    Size = new Size(100, 25)
                };

                //add click event to button
                accountButton.Click += accountButton_Click;



                //Jin - added in home page
                panel1.Visible = true;
                panel1.Controls.Add(accountButton);
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                //flowLayoutPanel1.Visible = false;

                InitializeStore();

                //created panel7 (account panel)
                panel7 = new Panel
                {
                    Location = new Point(0, 0),
                    Size = new Size(800, 600),
                    Visible = false // Initially hidden
                };

                Button homeButton = new Button
                {
                    Text = "Go to Homepage",
                    Location = new Point(155, 170),
                    Size = new Size(100, 50)
                };

                Button changePassword = new Button
                {
                    Text = "Change Password",
                    Location = new Point(155, 30),
                    Size = new Size(100, 40)
                };

                Button pastPurchases = new Button
                {
                    Text = "See Past Purchases",
                    Location = new Point(155, 80),
                    Size = new Size(100, 40)
                };

                Button logout = new Button
                {
                    Text = "Log Out",
                    Location = new Point(155, 130),
                    Size = new Size(100, 25)
                };

                //add click event to back button
                homeButton.Click += homeButton_Click;

                //add click event to change password button
                changePassword.Click += changePassword_Click;

                //add click event to past purchases button
                pastPurchases.Click += pastPurchases_Click;

                //add click event to log out button
                logout.Click += logout_Click;

                //add homeButton to panel 7
                panel7.Controls.Add(homeButton);
                panel7.Controls.Add(changePassword);
                panel7.Controls.Add(pastPurchases);
                panel7.Controls.Add(logout);

                this.Controls.Add(panel7);

            }


            private void accountButton_Click(object sender, EventArgs e)
            {
                // Hide other panels and show Panel 7
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = true;
                panel7.BringToFront(); // Ensure Panel 7 is displayed on top
            }

            private void homeButton_Click(Object sender, EventArgs e)
            {
                panel7.Visible = false;
                panel1.Visible = true;
                flowLayoutPanel1.Visible = false;
            }

            private void changePassword_Click(object sender, EventArgs e)
            {
                changePasswordPanel = new Panel
                {
                    Location = new Point(0, 0),
                    Size = new Size(400, 200),
                };

                Label oldPasswordLabel = new Label
                {
                    Text = "Enter Old Password:",
                    Location = new Point(10, 10),
                    AutoSize = true
                };
                oldPasswordBox = new TextBox
                {
                    Location = new Point(150, 10),
                    Width = 200
                };

                Label newPasswordLabel = new Label
                {
                    Text = "Enter New Password:",
                    Location = new Point(10, 50),
                    AutoSize = true
                };
                newPasswordBox = new TextBox
                {
                    Location = new Point(150, 50),
                    Width = 200
                };

                Label confirmPasswordLabel = new Label
                {
                    Text = "Confirm New Password:",
                    Location = new Point(10, 90),
                    AutoSize = true
                };
                confirmPasswordBox = new TextBox
                {
                    Location = new Point(150, 90),
                    Width = 200
                };

                Button savePasswordButton = new Button
                {
                    Text = "Save Password",
                    Location = new Point(150, 140),
                    Width = 150
                };

                Button homepageButton = new Button
                {
                    Text = "Back to Homepage",
                    Location = new Point(150, 170),
                    Width = 150
                };

                changePasswordPanel.Controls.Add(oldPasswordLabel);
                changePasswordPanel.Controls.Add(oldPasswordBox);
                changePasswordPanel.Controls.Add(newPasswordLabel);
                changePasswordPanel.Controls.Add(newPasswordBox);
                changePasswordPanel.Controls.Add(confirmPasswordLabel);
                changePasswordPanel.Controls.Add(confirmPasswordBox);
                changePasswordPanel.Controls.Add(savePasswordButton);
                changePasswordPanel.Controls.Add(homepageButton);

                savePasswordButton.Click += savePasswordButton_Click;
                homepageButton.Click += homeButton2_Click;

                this.Controls.Add(changePasswordPanel);

                panel7.Visible = false;
                changePasswordPanel.Visible = true;
                changePasswordPanel.BringToFront();
            }

            private void homeButton2_Click(Object sender, EventArgs e)
            {
                changePasswordPanel.Visible = false;
                panel1.Visible = true;
            }


            private void pastPurchases_Click(object sender, EventArgs e)
            {
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.BringToFront();
                DisplayPastP();
            }

            private void logout_Click(object sender, EventArgs e)
            {
                //Close Form2
                this.Close();
            }

            //options page
            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            //Jin - added in comfort page
            private void button1_Click(object sender, EventArgs e)
            {
                panel1.Visible = false;
                panel3.Visible = false;
                panel2.Visible = true;
                flowLayoutPanel1.Visible = true;

                //Dessa added display
                DisplayProducts("Comfort");


            }

            //Jin - added in Electronics page
            private void button2_Click(object sender, EventArgs e)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                //Dessa added display
                DisplayProducts("Electronics");

            }

            //Jin - added in Food Page
            private void button3_Click(object sender, EventArgs e)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                //Dessa added display
                DisplayProducts("Food");

            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void panel4_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void panel5_Paint(object sender, PaintEventArgs e)
            {

            }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            //Jin - added in checkout button at shopping cart page, takes it to the last page = panel 6
            private void button4_Click(object sender, EventArgs e)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = false;
                button4.Visible = false;

                flowLayoutPanel1.Visible = false;
                panel6.BringToFront();
                //Clear Cart and add to pastPurchases, then save in file
                foreach (Product item in cart)
                {
                    Form1.instance.pastPurchases.Add(item);
                }
                cart.Clear();
                Save(Form1.instance.currentUser, cart, Form1.instance.pastPurchases);



            }

            private void panel6_Paint(object sender, PaintEventArgs e)
            {

            }

            //Jin - added in checkout button for food section page
            private void button6_Click(object sender, EventArgs e)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                button10.Visible = true;
                //flowLayoutPanel1.Location = new Point(88, 111);
                //flowLayoutPanel1.Size = new Size(487, 193);
                //button4.BringToFront();
                flowLayoutPanel1.Controls.Clear();
                DisplayCart();
                // panel5.BringToFront();


            }

            //Jin - added in checkout button for Electronics page
            private void button7_Click(object sender, EventArgs e)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                button4.BringToFront();
                //flowLayoutPanel1.Location = new Point(88, 111);
                //flowLayoutPanel1.Size = new Size(487, 193);
                flowLayoutPanel1.Controls.Clear();
                DisplayCart();
                //  panel5.BringToFront();
            }

            //Jin - added in checkout button for Comfort page
            private void button8_Click(object sender, EventArgs e)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                //flowLayoutPanel1.Location = new Point(88, 111);
                //flowLayoutPanel1.Size = new Size(487, 193);
                flowLayoutPanel1.Controls.Clear();
                DisplayCart();
                // panel5.BringToFront();

            }

            //add in back to home page at the end      
            private void button5_Click_1(object sender, EventArgs e)
            {
                flowLayoutPanel1.Visible = false;
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
            }

            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

            //change password (yuri)
            private void savePasswordButton_Click(object sender, EventArgs e)
            {

                bool found = false;
                string filePath = "../../../Data.txt";

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
                    if (parts.Length > 1 && parts[1].Equals(oldPasswordBox.Text) && !found)
                    {


                        // Update the password for current user
                        entries[i] = ($"{parts[0]}|{newPasswordBox.Text}|{parts[2]}|{parts[3]}");
                        //user, password, pastpurchases separated by commas, cart separated by commas
                        found = true;//stop searching once it is found
                        Console.WriteLine($"Data saved under {parts[0]}");
                    }
                }
                if (!found) Console.WriteLine("Error"); //if something messed up and no user is found, declare that.
                File.WriteAllLines(filePath, entries);
            }

            //Jin - Back button for home page from Comfort Page
            private void button9_Click(object sender, EventArgs e)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                flowLayoutPanel1.Visible = false;
            }

            //Jin - Back button for home page from Electronics Page
            private void button10_Click(object sender, EventArgs e)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                flowLayoutPanel1.Visible = false;
            }

            //Jin - Back button for home page from Food Page
            private void button11_Click(object sender, EventArgs e)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                flowLayoutPanel1.Visible = false;
            }



            //save data function (yuri)
            public static void Save(string username, List<Product> cart, List<Product> pastPurchases)
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
                            pastPurchaseArray[pastPurchases.IndexOf(item)] = (item.ToString());
                        }

                        // Update the data for current user
                        entries[i] = ($"{username}|{parts[1]}|{String.Join(',', pastPurchases)}|{String.Join(',', storedCartArray)}");

                        //user, password, pastpurchases separated by commas, cart separated by commas
                        found = true;//stop searching once it is found
                        Console.WriteLine($"Data saved under {username}");


                    }
                }
                if (!found) Console.WriteLine("Error"); //if something messed up and no user is found, declare that.
                File.WriteAllLines(filePath, entries);
            }

        private void button12_Click(object sender, EventArgs e)
        {
            // Hide all panels except panel1
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;

            // Ensure flowLayoutPanel1 is also hidden
            flowLayoutPanel1.Visible = false;
        }
    }
    //Product Class
    //Created by Dessa
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public List<Rating> Ratings { get; set; }
        public string ShippingTime { get; set; }

            //initalize
            public Product(string name, decimal price, string category, List<Rating> ratings, string shippingTime)
            {
                Name = name;
                Price = price;
                Category = category;
                Ratings = ratings;
                ShippingTime = shippingTime;
            }
            //Method
            //Created by Shawn, optimized for saving to Data.txt
            public override string ToString()
            {
                return $"{Name},{Price},{Category},{string.Join("~", Ratings)}, {ShippingTime}";
            }
        }

        //Rating Class
        //Created by Dessa
        public class Rating
        {
            public int Stars { get; private set; }
            public string Comment { get; private set; }
            public string Username { get; private set; }
            public Rating(int stars, string comment, string username)
            {
                if (stars < 1 || stars > 5)
                {
                    throw new ArgumentException("Rating must be between 1 and 5");
                }

                Stars = stars;
                Comment = comment;
                Username = username;
            }
            //Method
            //Created by Shawn, optimized for saving to Data.txt
            public override string ToString()
            {
                return $"{Stars}:{Comment}:{Username}";
            }
        }
    }


