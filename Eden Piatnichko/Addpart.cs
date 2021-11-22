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
    public partial class Addpart : Form
    {


        public Addpart()
        {
            InitializeComponent();

        }
        // Shows Machine ID if radio button for InHouse is checked as well as the tool tip
        private void radioAddprtInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Machine ID";
            toolTip1.SetToolTip(tBoxMachOrComp, "Requires Number");
        }
        //Shows Company Name if OutSourced button is checked as well as the tool tip
        private void radioAddprtOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Company Name";
            toolTip1.SetToolTip(tBoxMachOrComp, "Requires Text");
        }
        private void Addpart_Load(object sender, EventArgs e)
        {

        }
        // Save button has several exception handling codes and saves added parts
        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            //Prevents user from saving when any of the textboxes are empty
            if (tBoxAddprtName.Text.Trim() == string.Empty || tBoxAddprtPrice.Text.Trim() == string.Empty || tBoxAddprtInv.Text.Trim() == string.Empty || tBoxAddprtMin.Text.Trim() == string.Empty || tBoxAddprtMax.Text.Trim() == string.Empty || tBoxMachOrComp.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            // Prevents user from saving if the textboxes are red
            if (tBoxAddprtName.BackColor == Color.Red || tBoxAddprtPrice.BackColor == Color.Red || tBoxAddprtInv.BackColor == Color.Red || tBoxAddprtMin.BackColor == Color.Red || tBoxAddprtMax.BackColor == Color.Red || tBoxMachOrComp.BackColor == Color.Red)
            {
                MessageBox.Show("Please correct the red box(s)");
                return;
            }
            //Prevents user from saving if min is greater than max
            if (int.Parse(tBoxAddprtMin.Text) > int.Parse(tBoxAddprtMax.Text))
            {
                MessageBox.Show("Minumum cannot be bigger than Maximum");
                return;
            }
            //Prevents user from saving if inventory is greater than max
            if (int.Parse(tBoxAddprtMin.Text) > int.Parse(tBoxAddprtInv.Text) || int.Parse(tBoxAddprtMax.Text) < int.Parse(tBoxAddprtInv.Text))
            {
                MessageBox.Show("Inventory amount must be between min and max");
                return;
            }
            // Saves Inhouse if radio button is checked
            if (radioAddprtInHouse.Checked)
            {
                InhousePart part = new InhousePart(int.Parse(tBoxAddprtID.Text), tBoxAddprtName.Text, int.Parse(tBoxAddprtInv.Text), decimal.Parse(tBoxAddprtPrice.Text), int.Parse(tBoxAddprtMax.Text), int.Parse(tBoxAddprtMin.Text), int.Parse(tBoxMachOrComp.Text));
                Inventory.AddPart(part);
            }
            //Saves OutSourced if radio button is checked
            else
            {
                OutsourcedPart part = new OutsourcedPart(int.Parse(tBoxAddprtID.Text), tBoxAddprtName.Text, int.Parse(tBoxAddprtInv.Text), decimal.Parse(tBoxAddprtPrice.Text), int.Parse(tBoxAddprtMax.Text), int.Parse(tBoxAddprtMin.Text), tBoxMachOrComp.Text);
                Inventory.AddPart(part);
            }
            
            this.Close();
        }
        //Textboxes bellow check for non numeric or numeric and if boxes are empty. Shows red and save button is disabled.
        private void tBoxAddprtName_TextChanged(object sender, EventArgs e)
        {
            if  (int.TryParse(tBoxAddprtName.Text, out int n) || string.IsNullOrEmpty(tBoxAddprtName.Text))
            {
                tBoxAddprtName.BackColor = Color.Red;
                buttonAddSave.Enabled = false;
                
                
            }
            else
            {
                tBoxAddprtName.BackColor = Color.White;
                buttonAddSave.Enabled = true;
            }
           
        }

        private void tBoxAddprtInv_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxAddprtInv.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprtInv.Text))
            {
                tBoxAddprtInv.BackColor = Color.Red;
                buttonAddSave.Enabled = false;
            }
            else
            {
                tBoxAddprtInv.BackColor = Color.White;
                buttonAddSave.Enabled = true;
            }
            
        }

        private void tBoxAddprtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tBoxAddprtPrice.Text, out decimal n) || string.IsNullOrWhiteSpace(tBoxAddprtPrice.Text))
            {
                tBoxAddprtPrice.BackColor = Color.Red;
                buttonAddSave.Enabled = false;
            }
            else
            {
                tBoxAddprtPrice.BackColor = Color.White;
                buttonAddSave.Enabled = true;
            }
            
        }

        private void tBoxAddprtMax_TextChanged(object sender, EventArgs e)
        {
            {
                if (!int.TryParse(tBoxAddprtMax.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprtMax.Text))
                {
                    tBoxAddprtMax.BackColor = Color.Red;
                    buttonAddSave.Enabled = false;
                }
                else
                {
                    tBoxAddprtMax.BackColor = Color.White;
                    buttonAddSave.Enabled = true;
                }
                
            }
        }

        private void tBoxAddprtMin_TextChanged(object sender, EventArgs e)
        {
            {
                if (!int.TryParse(tBoxAddprtMin.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprtMin.Text))
                {
                    tBoxAddprtMin.BackColor = Color.Red;
                    buttonAddSave.Enabled = false;
                }
                else
                {
                    tBoxAddprtMin.BackColor = Color.White;
                    buttonAddSave.Enabled = true;
                }
                
            }
        }
        // This text box changes based on radio button checked and detects for numeric or non numeric respectively
        private void tBoxMachOrComp_TextChanged(object sender, EventArgs e)
        {
            if (radioAddprtInHouse.Checked)
            {
                if ((!int.TryParse(tBoxMachOrComp.Text, out int n) || string.IsNullOrEmpty(tBoxMachOrComp.Text)))
                {
                    tBoxMachOrComp.BackColor = Color.Red;
                    buttonAddSave.Enabled = false;
                }
                else
                {
                    tBoxMachOrComp.BackColor = Color.White;
                    buttonAddSave.Enabled = true;
                }
            }
            else
            {
                if ((int.TryParse(tBoxMachOrComp.Text, out int n) || string.IsNullOrEmpty(tBoxMachOrComp.Text)))
                {
                    tBoxMachOrComp.BackColor = Color.Red;
                    buttonAddSave.Enabled = false;
                }
                else
                {
                    tBoxMachOrComp.BackColor = Color.White;
                    buttonAddSave.Enabled = true;
                }
            }
        }

        private void tBoxAddprtID_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxAddprtID.Text, out int n) || string.IsNullOrWhiteSpace(tBoxAddprtID.Text))
            {
                tBoxAddprtID.BackColor = Color.Red;
                buttonAddSave.Enabled = false;
            }
            else
            {
                tBoxAddprtID.BackColor = Color.White;
                buttonAddSave.Enabled = true;
            }
        }
    }
}
