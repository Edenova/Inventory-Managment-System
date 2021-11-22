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
    public partial class ModifyPart : Form
    {
        public ModifyPart(Part part)
        {
            // Loads current selected part and checks if it is inhouse or outsourced part
            InitializeComponent();
            if (part.GetType()== typeof (InhousePart))
            {
                radioModprtInHouse.Checked = true;
                ModBoxMachOrComp.Text = ((InhousePart)part).MachineID.ToString();
            }
            else
            {
                radioModprtOutsourced.Checked = true;
                ModBoxMachOrComp.Text = ((OutsourcedPart)part).CompanyName;
            }
            tBoxModprtName.Text = part.Name;
            tBoxModprtInv.Text = part.InStock.ToString();
            tBoxModprtPrice.Text = part.Price.ToString();
            tBoxModprtMax.Text = part.Max.ToString();
            tBoxModprtMin.Text = part.Min.ToString();
            tBoxModprtID.Text = part.PartID.ToString();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Textboxes bellow check for blank boxes and numeric or non numeric values where appropriate. Show red box and disable save button. 
        private void tBoxAddprtMin_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxModprtMin.Text, out int n) || string.IsNullOrWhiteSpace(tBoxModprtMin.Text))
            {
                tBoxModprtMin.BackColor = Color.Red;
                buttonModprtSave.Enabled = false;
            }
            else
            {
                tBoxModprtMin.BackColor = Color.White;
                buttonModprtSave.Enabled = true;
            }
        }

        private void tBoxAddprtMax_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxModprtMax.Text, out int n) || string.IsNullOrWhiteSpace(tBoxModprtMax.Text))
            {
                tBoxModprtMax.BackColor = Color.Red;
                buttonModprtSave.Enabled = false;
            }
            else
            {
                tBoxModprtMax.BackColor = Color.White;
                buttonModprtSave.Enabled = true;
            }
        }

        private void tBoxAddprtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tBoxModprtPrice.Text, out decimal n) || string.IsNullOrWhiteSpace(tBoxModprtPrice.Text))
            {
                tBoxModprtPrice.BackColor = Color.Red;
                buttonModprtSave.Enabled = false;
            }
            else
            {
                tBoxModprtPrice.BackColor = Color.White;
                buttonModprtSave.Enabled = true;
            }
        }

        private void tBoxAddprtInv_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxModprtInv.Text, out int n) || string.IsNullOrWhiteSpace(tBoxModprtInv.Text))
            {
                tBoxModprtInv.BackColor = Color.Red;
                buttonModprtSave.Enabled = false;
            }
            else
            {
                tBoxModprtInv.BackColor = Color.White;
                buttonModprtSave.Enabled = true;
            }
        }

        private void tBoxAddprtName_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tBoxModprtName.Text, out int n) || string.IsNullOrWhiteSpace(tBoxModprtName.Text))
            {
                tBoxModprtName.BackColor = Color.Red;
                buttonModprtSave.Enabled = false;
            }
            else
            {
                tBoxModprtName.BackColor = Color.White;
                buttonModprtSave.Enabled = true;
            }
        }

        private void tBoxAddprtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAddCacncel_Click(object sender, EventArgs e)
        {

        }
        // Save button has several exception handling codes and saves modified parts
        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            //Prevents user from saving when any of the textboxes are empty
            if (tBoxModprtName.Text.Trim() == string.Empty || tBoxModprtPrice.Text.Trim() == string.Empty || tBoxModprtInv.Text.Trim() == string.Empty || tBoxModprtMin.Text.Trim() == string.Empty || tBoxModprtMax.Text.Trim() == string.Empty || ModBoxMachOrComp.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            // Prevents user from saving if the textboxes are red
            if (tBoxModprtName.BackColor == Color.Red || tBoxModprtPrice.BackColor == Color.Red || tBoxModprtInv.BackColor == Color.Red || tBoxModprtMin.BackColor == Color.Red || tBoxModprtMax.BackColor == Color.Red || ModBoxMachOrComp.BackColor == Color.Red)
            {
                MessageBox.Show("Please correct the red box(s)");
                return;
            }
            //Prevents user from saving if min is greater than max
            if (int.Parse(tBoxModprtMin.Text) > int.Parse(tBoxModprtMax.Text))
            {
                MessageBox.Show("Minumum cannot be bigger than Maximum");
                return;
            }
            //Prevents user from saving if inventory is greater than max
            if (int.Parse(tBoxModprtMin.Text) > int.Parse(tBoxModprtInv.Text) || int.Parse(tBoxModprtMax.Text) < int.Parse(tBoxModprtInv.Text))
            {
                MessageBox.Show("Inventory amount must be between min and max");
                return;
            }
            //If InHouse radio button is checked Saves modified part to InHouse
            if (radioModprtInHouse.Checked)
            {
                InhousePart part = new InhousePart(int.Parse(tBoxModprtID.Text), tBoxModprtName.Text, int.Parse(tBoxModprtInv.Text), decimal.Parse(tBoxModprtPrice.Text), int.Parse(tBoxModprtMax.Text), int.Parse(tBoxModprtMin.Text), int.Parse(ModBoxMachOrComp.Text));
                Inventory.UpdatePart(part.PartID,part);
            }
            //If Outsourced radio button is checked saves modified part to outsourced
            else
            {
                OutsourcedPart part = new OutsourcedPart(int.Parse(tBoxModprtID.Text), tBoxModprtName.Text, int.Parse(tBoxModprtInv.Text), decimal.Parse(tBoxModprtPrice.Text), int.Parse(tBoxModprtMax.Text), int.Parse(tBoxModprtMin.Text), ModBoxMachOrComp.Text);
                Inventory.UpdatePart(part.PartID,part);
            }

            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelMin_Click(object sender, EventArgs e)
        {

        }

        private void labelMax_Click(object sender, EventArgs e)
        {

        }

        private void labelPriceCost_Click(object sender, EventArgs e)
        {

        }

        private void labelInventory_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }
        // Shows company name and appropriate tooltip if outsource radio button is checked
        private void radioAddprtOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Company Name";
            toolTip2.SetToolTip(ModBoxMachOrComp, "Requires Text");
        }
        //Shows machine ID and appropriate tooltip if InHouse radio button is checked
        private void radioAddprtInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Machine ID";
            toolTip2.SetToolTip(ModBoxMachOrComp, "Requires Number");
        }
        //This text box changes based on radio button checked and detects for numeric or non numeric respectively
        private void tBoxMachOrComp_TextChanged(object sender, EventArgs e)
        {
            if (radioModprtInHouse.Checked)
            {
                if ((!int.TryParse(ModBoxMachOrComp.Text, out int n) || string.IsNullOrEmpty(ModBoxMachOrComp.Text)))
                {
                    ModBoxMachOrComp.BackColor = Color.Red;
                    buttonModprtSave.Enabled = false;
                }
                else
                {
                    ModBoxMachOrComp.BackColor = Color.White;
                    buttonModprtSave.Enabled = true;
                }
            }
            else
            {
                if ((int.TryParse(ModBoxMachOrComp.Text, out int n) || string.IsNullOrEmpty(ModBoxMachOrComp.Text)))
                {
                    ModBoxMachOrComp.BackColor = Color.Red;
                    buttonModprtSave.Enabled = false;
                }
                else
                {
                    ModBoxMachOrComp.BackColor = Color.White;
                    buttonModprtSave.Enabled = true;
                }
            }
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }
    }
}
