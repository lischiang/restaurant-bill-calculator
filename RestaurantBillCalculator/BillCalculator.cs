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
    public partial class BillCalculator : Form
    {
        public BillCalculator()
        {
            InitializeComponent();
        }

        string[] beverage = { "Soda", "Tea", "Coffee", "Mineral Water", "Juice", "Milk" };
        double[] beveragePrice = { 1.95, 1.50, 1.25, 2.95, 2.50, 1.50};

        string[] appetizer = { "Buffalo Wings", "Buffalo Fingers", "Potato Skins", "Nachos",
            "Mashroom Caps", "Shrimp Cocktail", "Chips and Salsa"};
        double[] appetizerPrice = {5.95, 6.95, 8.95, 8.95, 10.95, 12.95, 6.95 };

        string[] mainCourse = { "Seafood Alfredo", "Chicken Alfredo", "Chicken Picatta", "Turkey Club",
            "Lobster Pie", "Prime Rib", "Shrimp Scampi", "Turkey Dinner", "Stuffed Chicken" };
        double[] mainCoursePrice = { 15.95, 13.95, 13.95, 11.95, 19.95, 20.95, 18.95, 13.95, 14.95 };

        string[] dessert = { "Apple Pie", "Sundae", "Carrot Cake", "Mud Pie", "Apple Crisp" };
        double[] dessertPrice = { 5.95, 3.95, 5.95, 4.95, 5.95};
 
        double taxPercentage = 13;

        private void comboBoxBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxBeverage.SelectedIndex;

            // verify that the index is not -1 
            if (selectedIndex == -1)
            {
                return;
            }

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
                    beverage[selectedIndex], "Beverage", beveragePrice[selectedIndex].ToString("N2"),
                    "1", beveragePrice[selectedIndex].ToString("N2") };
                dataGridView1.Rows.Add(row);
            }
            else
            {
                //MessageBox.Show("Already added, position " + counter);
                dataGridView1.Rows[counter].Cells[3].Value = 
                    Int32.Parse(dataGridView1.Rows[counter].Cells[3].Value.ToString()) + 1;
                
            }
            // Update subtotal
            updateSubtotal();
        }

        private void comboBoxAppetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxAppetizer.SelectedIndex;

            // verify that the index is not -1 
            if (selectedIndex == -1)
            {
                return;
            }

            bool found = false; // to verify if the item has been added to the bill already

            // go through the items in the bill to see if the selected one exists already
            int counter = 0;
            while (!found && counter < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[counter].Cells[0].Value.ToString() == appetizer[selectedIndex])
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
                    appetizer[selectedIndex], "Appetizer", appetizerPrice[selectedIndex].ToString("N2"),
                    "1", appetizerPrice[selectedIndex].ToString("N2") };
                dataGridView1.Rows.Add(row);
            }
            else
            {
                dataGridView1.Rows[counter].Cells[3].Value =
                    Int32.Parse(dataGridView1.Rows[counter].Cells[3].Value.ToString()) + 1;
            }
            // Update subtotal
            updateSubtotal();
        }

        private void comboBoxMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxMainCourse.SelectedIndex;

            // verify that the index is not -1 
            if (selectedIndex == -1)
            {
                return;
            }

            bool found = false; // to verify if the item has been added to the bill already

            // go through the items in the bill to see if the selected one exists already
            int counter = 0;
            while (!found && counter < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[counter].Cells[0].Value.ToString() == mainCourse[selectedIndex])
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
                    mainCourse[selectedIndex], "Main Course", mainCoursePrice[selectedIndex].ToString("N2"),
                    "1", mainCoursePrice[selectedIndex].ToString("N2") };
                dataGridView1.Rows.Add(row);
            }
            else
            {
                dataGridView1.Rows[counter].Cells[3].Value =
                    Int32.Parse(dataGridView1.Rows[counter].Cells[3].Value.ToString()) + 1;
            }
            // Update subtotal
            updateSubtotal();
        }

        private void comboBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxDessert.SelectedIndex;

            // verify that the index is not -1 
            if (selectedIndex == -1)
            {
                return;
            }

            bool found = false; // to verify if the item has been added to the bill already

            // go through the items in the bill to see if the selected one exists already
            int counter = 0;
            while (!found && counter < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[counter].Cells[0].Value.ToString() == dessert[selectedIndex])
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
                    dessert[selectedIndex], "Dessert", dessertPrice[selectedIndex].ToString("N2"),
                    "1", dessertPrice[selectedIndex].ToString("N2") };
                dataGridView1.Rows.Add(row);
            }
            else
            {
                dataGridView1.Rows[counter].Cells[3].Value =
                    Int32.Parse(dataGridView1.Rows[counter].Cells[3].Value.ToString()) + 1;
            }
            // Update subtotal
            updateSubtotal();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            double subtotal = Double.Parse(txtSubtotal.Text);
            double tax = subtotal * taxPercentage / 100;
            txtTax.Text = tax.ToString("N2");
            txtTotal.Text = (subtotal + tax).ToString("N2");
            dataGridView1.Enabled = false;
            btnCheckOut.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // To avoid these instructions to be executed when the form is initialized
            if (e.RowIndex == -1)
            {
                return;
            }

            // Update the total product price 
            double priceSelectedProduct = Double.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            int updatedQuantity = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            double productTotal = priceSelectedProduct * updatedQuantity;
            dataGridView1.Rows[e.RowIndex].Cells[4].Value = productTotal.ToString("N2");
            // Update the subtotal of the bill
            updateSubtotal();            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            updateSubtotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView1.Rows.Clear();
            btnCheckOut.Enabled = true;
            btnRemove.Enabled = true;
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            comboBoxBeverage.SelectedIndex = -1;
            comboBoxAppetizer.SelectedIndex = -1;
            comboBoxMainCourse.SelectedIndex = -1;
            comboBoxDessert.SelectedIndex = -1;
        }

        // Method to sum the product totals to update the bill subtotal
        private void updateSubtotal()
        {
            double subtotal = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                subtotal += Double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            txtSubtotal.Text = subtotal.ToString("N2");
        }
    }
}
