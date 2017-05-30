using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] beverage = { "Soda", "Tea", "Coffee", "Mineral Water", "Juice", "Milk" };
        double[] beveragePrice = { 1.95, 1.50, 1.25, 2.95, 2.50, 1.50};

        string[] appetizer = { "Buffalo Wings", "Buffalo Fingers", "Potato Skins", "Nachos",
            "Mashroom Caps", "Shrimp Cocktail", "Chips and Salsa"};
        string[] mainCourse = { "Seafood Alfredo", "Chicken Picatta", "Turkey Club",
            "Lobster Pie", "Prime Rib", "Shrimp Scampi", "Turkey Dinner", "Stuffed Chicken" };
        string[] dessert = { "Apple Pie", "Sundae", "Carrot Cake", "Mud Pie", "Apple Crisp" };

        double subtotal = 0;    // subtotal of the bill
        double taxPercentage = 13;

        private void comboBoxBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxBeverage.SelectedIndex;
            bool found = false; // to verify if the item has been added to the bill already

            // go through the items in the bill to see if the selected one exists already
            int counter = 0;
            while (!found && counter < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[counter].Cells[0].Value.ToString() == beverage[selectedIndex])
                {
                    found = true;
                }
                else
                {
                    counter++;
                }
            }

            // If the item has not been added to the gridview yet, add a new line; otherwise update the quantity
            if (!found)
            {
                string[] row = new string[] {
                    beverage[selectedIndex], "Beverage", beveragePrice[selectedIndex].ToString(),
                    "1", beveragePrice[selectedIndex].ToString("N2") };
                dataGridView1.Rows.Add(row);
                subtotal += beveragePrice[selectedIndex];   // update the subtotal
                txtSubtotal.Text = subtotal.ToString("N2");
            }
            else
            {
                //MessageBox.Show("Already added, position " + counter);
                dataGridView1.Rows[counter].Cells[3].Value = 
                    Int32.Parse(dataGridView1.Rows[counter].Cells[3].Value.ToString()) + 1;
                
            } 
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            double tax = subtotal * taxPercentage / 100;
            txtTax.Text = tax.ToString("N2");
            txtTotal.Text = (subtotal + tax).ToString("N2");
            dataGridView1.Enabled = false;
            btnCheckOut.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            // Retrieve the unit price of the product whose quantity has been changed
            bool found = false;
            int counter = 0;
            // if the product is a Beverage
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Beverage")
            {
                while (!found && counter < beverage.Length)
                {
                    if (beverage[counter] == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        found = true;
                        MessageBox.Show("Found! position " + counter);
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
            // if the product is a Appetizer
            // if the product is a Main Course
            // if the product is a Dessert
            
            if (!found)
            {
                MessageBox.Show("Unexpected error!");
            }  
            else
            {
                int updatedQuantity = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                double productTotal = beveragePrice[counter]* updatedQuantity;
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = productTotal.ToString("N2");
                updateSubtotal();
            }
        }

        private void updateSubtotal()
        {
            double subtotal = 0;
            for (int i = 0; i<dataGridView1.RowCount; i++)
            {
                subtotal += Double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            txtSubtotal.Text = subtotal.ToString("N2");
        }
    }
}
