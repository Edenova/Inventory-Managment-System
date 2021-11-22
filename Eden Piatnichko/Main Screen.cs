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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // This generates the main screen lists for Parts and Products

            var partlist = new BindingSource();
            partlist.DataSource = Inventory.parts;
            mainPrtGridView.DataSource = partlist;

            Inventory.Partslist();


            Inventory.Productlist();

            var prodlist = new BindingSource();
            prodlist.DataSource = Inventory.products;
            mainProdGridView.DataSource = prodlist;

            

        
        
        
        
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // Closes program
        private void exiBbtn_Click(object sender, EventArgs e)
        {
            //This Exits the program.
            this.Close();
        }
        //Opens add part screen
        private void Addbtn_Parts_Click(object sender, EventArgs e)
        {
            Addpart addpart = new Addpart();
            addpart.ShowDialog();
            //new Addpart().ShowDialog();
        }
        //Opens modify part screen
        private void Modifybtn_parts_Click(object sender, EventArgs e)
        {
            ModifyPart modifyPart = new ModifyPart((Part)mainPrtGridView.SelectedRows[0].DataBoundItem);
            
            modifyPart.ShowDialog();
        }
        // Opens add product screen
        private void Addbtn_Prod_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }
        // Opens modify product screen
        private void Modifybtn_prod_Click(object sender, EventArgs e)
        {
            ModifyProduct modifyProduct = new ModifyProduct((Product)mainProdGridView.SelectedRows[0].DataBoundItem);
            modifyProduct.ShowDialog();
        }
        //Deletes selected part and full row confirms delete
        private void Deletebtn_parts_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            foreach (DataGridViewCell viewCell in mainPrtGridView.SelectedCells)
            {
                if (viewCell.Selected)
                    mainPrtGridView.Rows.RemoveAt(viewCell.RowIndex);
            }
        }
        // Deletes selected products if there are no associated parts linked to it and full row
        private void Deletebtn_prod_Click(object sender, EventArgs e)
        {
            Product product = (Product)mainProdGridView.SelectedRows[0].DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("This product has an associated part and cannot be deleted","Error");
                return;
            }
            if (MessageBox.Show("Do you want to delete this part?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                foreach (DataGridViewCell viewCell in mainProdGridView.SelectedCells)
            {
                if (viewCell.Selected)
                    mainProdGridView.Rows.RemoveAt(viewCell.RowIndex);
            }
        }
        //searches parts case sensitive
        private void SearchParts_Click(object sender, EventArgs e)
        {
            string searchValue = SearchBoxParts.Text;
            mainPrtGridView.ClearSelection();
            
            try
            {
                foreach (DataGridViewRow row in mainPrtGridView.Rows)
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
        //searches products case sensitive
        private void SearchProducts_Click(object sender, EventArgs e)
        {
            string searchValue = searchBoxProd.Text;
            mainProdGridView.ClearSelection();

            try
            {
                foreach (DataGridViewRow row in mainProdGridView.Rows)
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
