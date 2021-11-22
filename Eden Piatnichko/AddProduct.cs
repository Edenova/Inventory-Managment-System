using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eden_Piatnichko
{
    public partial class AddProduct : Form
    {
        BindingList<Part> parts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            // Loads the top and bottom table with parts and associated parts 
            var partlist = new BindingSource();
            partlist.DataSource = Inventory.parts;
            addProdGridView1.DataSource = partlist;

            var addParts = new BindingSource();
            addParts.DataSource = parts;
            addProdGridView2.DataSource = addParts;

        }
        //Search for parts case sensitive
        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearchProd.Text;
            addProdGridView1.ClearSelection();

            try
            {
                foreach (DataGridViewRow row in addProdGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
        // Add button adds associated parts from top table to bottom
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            parts.Add((Part)addProdGridView1.SelectedRows[0].DataBoundItem);
        }
        // Save button has several exception handling codes and saves added products
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Prevents user from saving when any of the textboxes are empty
            if (tBoxAddprodName.Text.Trim() == string.Empty || tBoxAddprodPrice.Text.Trim() == string.Empty || tBoxAddprodInv.Text.Trim() == string.Empty || tBoxAddprodMin.Text.Trim() == string.Empty || tBoxAddprodMax.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            // Prevents user from saving if the textboxes are red
            if ( tBoxAddprodName.BackColor == Color.Red || tBoxAddprodPrice.BackColor == Color.Red || tBoxAddprodInv.BackColor == Color.Red || tBoxAddprodMin.BackColor == Color.Red || tBoxAddprodMax.BackColor == Color.Red)
            {
                MessageBox.Show("Please correct the red box(s)");
                return;
            }
            //Prevents user from saving if min is greater than max
            if (int.Parse(tBoxAddprodMin.Text) > int.Parse(tBoxAddprodMax.Text))
            {
                MessageBox.Show("Minumum cannot be bigger than Maximum");
                return;
            }
            //Prevents user from saving if inventory is greater than max
            if (int.Parse(tBoxAddprodMin.Text) > int.Parse(tBoxAddprodInv.Text) || int.Parse(tBoxAddprodMax.Text) < int.Parse(tBoxAddprodInv.Text))
            {
                MessageBox.Show("Inventory amount must be between min and max");
                return;
            }
           
            Product product = new Product(int.Parse(tBoxAddprodID.Text), tBoxAddprodName.Text, int.Parse(tBoxAddprodInv.Text), decimal.Parse(tBoxAddprodPrice.Text), int.Parse(tBoxAddprodMin.Text), int.Parse(tBoxAddprodMax.Text));
            foreach (Part Apart in parts)
            {
                product.addAssociatedPart(Apart);
            }

            Inventory.AddProduct(product);

            
            this.Close();
        }
        // Detects non numeric values for productID and marks box red as well as disables save button
        private void tBoxAddprodID_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxAddprodID.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprodID.Text))
            {
                tBoxAddprodID.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                tBoxAddprodID.BackColor = Color.White;
                buttonSave.Enabled = true;
            }

        }
        //Detects numeric values for Name and marks box red as well as disables save button
        private void tBoxAddprodName_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tBoxAddprodName.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprodName.Text))
            {
                tBoxAddprodName.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                tBoxAddprodName.BackColor = Color.White;
                buttonSave.Enabled = true;
            }

        }
        //Detects non numeric values for inventory and marks box red as well as disables save button
        private void tBoxAddprodInv_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxAddprodInv.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprodInv.Text))
            {
                tBoxAddprodInv.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                tBoxAddprodInv.BackColor = Color.White;
                buttonSave.Enabled = true;
            }

        }
        // Detects non numeric values for price and marks box red as well as disables save button
        private void tBoxAddprodPrice_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tBoxAddprodPrice.Text, out decimal n) || string.IsNullOrWhiteSpace(tBoxAddprodPrice.Text))
            {
                tBoxAddprodPrice.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                tBoxAddprodPrice.BackColor = Color.White;
                buttonSave.Enabled = true;
            }

        }
        // Detects non numeric values for max and marks box red as well as disables save button
        private void tBoxAddprodMax_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxAddprodMax.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprodMax.Text))
            {
                tBoxAddprodMax.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                tBoxAddprodMax.BackColor = Color.White;
                buttonSave.Enabled = true;
            }

        }
        //Detects non numeric values for min and marks box red as well as disables save button
        private void tBoxAddprodMin_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxAddprodMin.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprodMin.Text))
            {
                tBoxAddprodMin.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                tBoxAddprodMin.BackColor = Color.White;
                buttonSave.Enabled = true;
            }

        }
        // Delete button confirms delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                foreach (DataGridViewCell viewCell in addProdGridView2.SelectedCells)
                {
                    if (viewCell.Selected)
                        addProdGridView2.Rows.RemoveAt(viewCell.RowIndex);
                }
        }
    }
}
