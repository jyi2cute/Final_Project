using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{

    public partial class Form2 : Form
    {
        //Create the lists for all the products and the cart
        private List<Product> products = new List<Product>();
        private List<Product> cart = new List<Product>();

        private void InitializeStore()
        {
            //these are all the items 
            products.Add(new Product("Comforter Set", 49.99m, "Comfort", 4, "2 days"));
            products.Add(new Product("Bluetooth Headphones", 89.99m, "Electronics", 5, "3 days"));
            products.Add(new Product("Pizza Pack", 15.99m, "Food", 4, "1 day"));
            products.Add(new Product("Smartwatch", 129.99m, "Electronics", 5, "3 days"));
            products.Add(new Product("Plush Throw Blanket", 19.99m, "Comfort", 3, "2 days"));
        }

        private void DisplayProducts(string category = "All", string searchQuery = "")
        {
            flowLayoutPanelProducts.Controls.Clear();

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
                    Text = $"Rating: {new string('★', product.Rating)}",
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

                flowLayoutPanelProducts.Controls.Add(panel);
            }
        }

        public Form2()
        {
            InitializeComponent();


            //added in home page
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            InitializeStore();
            DisplayProducts();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //added in comfort page
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;

        }

        //added in Electronics page
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;

        }

        //added in Food Page
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
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

        //added in checkout page
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        //added in checkout button for food section page
        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
        }

        //added in checkout button for Electronics page
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
        }

        //added in checkout button for Comfort page
        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
        }

        //add in back to home page at the end      
        private void button5_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }
    }

    //Product Class
    //Dessa
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }
        public string ShippingTime { get; set; }

        //initalize
        public Product(string name, decimal price, string category, int rating, string shippingTime)
        {
            Name = name;
            Price = price;
            Category = category;
            Rating = rating;
            ShippingTime = shippingTime;
        }
    }
}
