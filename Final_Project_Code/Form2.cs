using System;
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
        }

        // Dessa Created function to dispkay the products
        private void DisplayProducts(string category = "All", string searchQuery = "")
        {
            //flowLayoutPanel1.Visible = false;
            flowLayoutPanel1.Controls.Clear();
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
                    MessageBox.Show($"{product.Name} added to cart!", "Cart Update");
                };

                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(ratingLabel);
                panel.Controls.Add(addToCartButton);

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
                Location = new Point(225, 170),
                Size = new Size(100, 50)
            };

            Button changePassword = new Button
            {
                Text = "Change Password",
                Location = new Point(225, 30),
                Size = new Size(100, 40)
            };

            Button pastPurchases = new Button
            {
                Text = "See Past Purchases",
                Location = new Point(225, 80),
                Size = new Size(100, 40)
            };

            Button logout = new Button
            {
                Text = "Log Out",
                Location = new Point(225, 130),
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
        }

        private void changePassword_Click(object sender, EventArgs e)
        {

        }

        private void pastPurchases_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {

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

        //Jin - added in checkout page
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
         //   panel5.BringToFront();

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        //Jin - added in checkout button for food section page
        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        //    panel5.BringToFront();


        }

        //Jin - added in checkout button for Electronics page
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            button4.BringToFront();
          //  panel5.BringToFront();
        }

        //Jin - added in checkout button for Comfort page
        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
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
                return $"{Name},{Price},{Category},{Ratings},{ShippingTime}";
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
            return $"{Stars},{Comment},{Username}";
        }
    }
    
}
