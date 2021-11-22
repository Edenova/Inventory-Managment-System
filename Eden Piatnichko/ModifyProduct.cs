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
    public partial class ModifyProduct : Form
    {
        BindingList<Part> parts = new BindingList<Part>();
        public ModifyProduct(Product product)
        {
            InitializeComponent();
            tBoxModProdID.Text = product.ProductID.ToString();
            tBoxModProdName.Text = product.Name;
            tBoxModProdInv.Text = product.InStock.ToString();
            tBoxModProdPrice.Text = product.Price.ToString();
            tBoxModProdMax.Text = product.Max.ToString();
            tBoxModProdMin.Text = product.Min.ToString();
            foreach (var item in product.AssociatedParts)
            {
                parts.Add(item);
            }
            // Loads top and bottom tables for parts and associated parts
            var partlist = new BindingSource();
            partlist.DataSource = Inventory.parts;
            modProdGridView1.DataSource = partlist;


            var addParts = new BindingSource();
            addParts.DataSource = parts;
            modProdGridView2.DataSource = addParts;
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }
        // Add button adds associated parts to bottom table
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            parts.Add((Part)modProdGridView1.SelectedRows[0].DataBoundItem);
        }
        //Save button has several exception handling codes and saves modified products
        private void buttonSaveProdMod_Click(object sender, EventArgs e)
        {
            ////Prevents user from saving when any of the textboxes are empty
            if (tBoxModProdName.Text.Trim() == string.Empty || tBoxModProdPrice.Text.Trim() == string.Empty || tBoxModProdInv.Text.Trim() == string.Empty || tBoxModProdMin.Text.Trim() == string.Empty || tBoxModProdMax.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            // Prevents user from saving if the textboxes are red
            if (tBoxModProdName.BackColor == Color.Red || tBoxModProdPrice.BackColor == Color.Red || tBoxModProdInv.BackColor == Color.Red || tBoxModProdMin.BackColor == Color.Red || tBoxModProdMax.BackColor == Color.Red)
            {
                MessageBox.Show("Please correct the red box(s)");
                return;
            }
            //Prevents user from saving if min is greater than max
            if (int.Parse(tBoxModProdMin.Text) > int.Parse(tBoxModProdMax.Text))
            {
                MessageBox.Show("Minumum cannot be bigger than Maximum");
                return;
            }
            //Prevents user from saving if inventory is greater than max or smaller than min
            if (int.Parse(tBoxModProdMin.Text) > int.Parse(tBoxModProdInv.Text) || int.Parse(tBoxModProdMax.Text) < int.Parse(tBoxModProdInv.Text))
            {
                MessageBox.Show("Inventory amount must be between min and max");
                return;
            }
            
            Product product = new Product(int.Parse(tBoxModProdID.Text), tBoxModProdName.Text, int.Parse(tBoxModProdInv.Text), decimal.Parse(tBoxModProdPrice.Text), int.Parse(tBoxModProdMin.Text), int.Parse(tBoxModProdMax.Text));
            foreach (Part Apart in parts)
            {
                product.addAssociatedPart(Apart);
            }
            Inventory.UpdateProduct(product.ProductID,product);
            
            this.Close();
        }
        // Checks all textbox bellow for if empty, numeric value, and shows red and disables save
        private void tBoxModProdName_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tBoxModProdName.Text, out int n) || string.IsNullOrWhiteSpace(tBoxModProdName.Text))
            {
                tBoxModProdName.BackColor = Color.Red;
                buttonSaveProdMod.Enabled = false;
            }
            else
            {
                tBoxModProdName.BackColor = Color.White;
                buttonSaveProdMod.Enabled = true;
            }

        }

        private void tBoxModProdInv_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxModProdInv.Text, out int n) || string.IsNullOrWhiteSpace(tBoxModProdInv.Text))
            {
                tBoxModProdInv.BackColor = Color.Red;
                buttonSaveProdMod.Enabled = false;
            }
            else
            {
                tBoxModProdInv.BackColor = Color.White;
                buttonSaveProdMod.Enabled = true;
            }

        }

        private void tBoxModProdPrice_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tBoxModProdPrice.Text, out decimal n) || string.IsNullOrWhiteSpace(tBoxModProdPrice.Text))
            {
                tBoxModProdPrice.BackColor = Color.Red;
                buttonSaveProdMod.Enabled = false;
            }
            else
            {
                tBoxModProdPrice.BackColor = Color.White;
                buttonSaveProdMod.Enabled = true;
            }

        }

        private void tBoxModProdMax_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxModProdMax.Text, out int n) || string.IsNullOrWhiteSpace(tBoxModProdMax.Text))
            {
                tBoxModProdMax.BackColor = Color.Red;
                buttonSaveProdMod.Enabled = false;
            }
            else
            {
                tBoxModProdMax.BackColor = Color.White;
                buttonSaveProdMod.Enabled = true;
            }

        }

        private void tBoxModProdMin_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxModProdMin.Text, out int n) || string.IsNullOrWhiteSpace(tBoxModProdMin.Text))
            {
                tBoxModProdMin.BackColor = Color.Red;
                buttonSaveProdMod.Enabled = false;
            }
            else
            {
                tBoxModProdMin.BackColor = Color.White;
                buttonSaveProdMod.Enabled = true;
            }

        }
        // Confrimation delete button
        private void buttonDeleteProdMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this associated part?", "Delete Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                foreach (DataGridViewCell viewCell in modProdGridView2.SelectedCells)
                {
                    if (viewCell.Selected)
                        modProdGridView2.Rows.RemoveAt(viewCell.RowIndex);
                }
        }
        //Searches parts case sensitive
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tBoxSearchModProd.Text;
            modProdGridView1.ClearSelection();

            try
            {
                foreach (DataGridViewRow row in modProdGridView1.Rows)
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
    }
}
