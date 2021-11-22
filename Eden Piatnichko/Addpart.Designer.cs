
namespace Eden_Piatnichko
{
    partial class Addpart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.radioAddprtInHouse = new System.Windows.Forms.RadioButton();
            this.radioAddprtOutsourced = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPriceCost = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddSave = new System.Windows.Forms.Button();
            this.buttonAddCacncel = new System.Windows.Forms.Button();
            this.tBoxAddprtID = new System.Windows.Forms.TextBox();
            this.tBoxAddprtName = new System.Windows.Forms.TextBox();
            this.tBoxAddprtInv = new System.Windows.Forms.TextBox();
            this.tBoxAddprtPrice = new System.Windows.Forms.TextBox();
            this.tBoxAddprtMax = new System.Windows.Forms.TextBox();
            this.tBoxAddprtMin = new System.Windows.Forms.TextBox();
            this.tBoxMachOrComp = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // radioAddprtInHouse
            // 
            this.radioAddprtInHouse.AutoSize = true;
            this.radioAddprtInHouse.Location = new System.Drawing.Point(181, 12);
            this.radioAddprtInHouse.Name = "radioAddprtInHouse";
            this.radioAddprtInHouse.Size = new System.Drawing.Size(68, 17);
            this.radioAddprtInHouse.TabIndex = 1;
            this.radioAddprtInHouse.TabStop = true;
            this.radioAddprtInHouse.Text = "In-House";
            this.radioAddprtInHouse.UseVisualStyleBackColor = true;
            this.radioAddprtInHouse.CheckedChanged += new System.EventHandler(this.radioAddprtInHouse_CheckedChanged);
            // 
            // radioAddprtOutsourced
            // 
            this.radioAddprtOutsourced.AutoSize = true;
            this.radioAddprtOutsourced.Location = new System.Drawing.Point(342, 12);
            this.radioAddprtOutsourced.Name = "radioAddprtOutsourced";
            this.radioAddprtOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioAddprtOutsourced.TabIndex = 2;
            this.radioAddprtOutsourced.TabStop = true;
            this.radioAddprtOutsourced.Text = "Outsourced";
            this.radioAddprtOutsourced.UseVisualStyleBackColor = true;
            this.radioAddprtOutsourced.CheckedChanged += new System.EventHandler(this.radioAddprtOutsourced_CheckedChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(31, 79);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 139);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(31, 204);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 5;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Location = new System.Drawing.Point(31, 263);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(60, 13);
            this.labelPriceCost.TabIndex = 6;
            this.labelPriceCost.Text = "Price/ Cost";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(52, 301);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(258, 301);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 8;
            this.labelMin.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // buttonAddSave
            // 
            this.buttonAddSave.Location = new System.Drawing.Point(342, 401);
            this.buttonAddSave.Name = "buttonAddSave";
            this.buttonAddSave.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSave.TabIndex = 10;
            this.buttonAddSave.Text = "Save";
            this.buttonAddSave.UseVisualStyleBackColor = true;
            this.buttonAddSave.Click += new System.EventHandler(this.buttonAddSave_Click);
            // 
            // buttonAddCacncel
            // 
            this.buttonAddCacncel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAddCacncel.Location = new System.Drawing.Point(423, 401);
            this.buttonAddCacncel.Name = "buttonAddCacncel";
            this.buttonAddCacncel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCacncel.TabIndex = 11;
            this.buttonAddCacncel.Text = "Cancel";
            this.buttonAddCacncel.UseVisualStyleBackColor = true;
            // 
            // tBoxAddprtID
            // 
            this.tBoxAddprtID.Location = new System.Drawing.Point(105, 79);
            this.tBoxAddprtID.Name = "tBoxAddprtID";
            this.tBoxAddprtID.Size = new System.Drawing.Size(155, 20);
            this.tBoxAddprtID.TabIndex = 12;
            this.toolTip1.SetToolTip(this.tBoxAddprtID, "Requires a number");
            this.tBoxAddprtID.TextChanged += new System.EventHandler(this.tBoxAddprtID_TextChanged);
            // 
            // tBoxAddprtName
            // 
            this.tBoxAddprtName.Location = new System.Drawing.Point(105, 139);
            this.tBoxAddprtName.Name = "tBoxAddprtName";
            this.tBoxAddprtName.Size = new System.Drawing.Size(155, 20);
            this.tBoxAddprtName.TabIndex = 13;
            this.toolTip1.SetToolTip(this.tBoxAddprtName, "Requires a text value");
            this.tBoxAddprtName.TextChanged += new System.EventHandler(this.tBoxAddprtName_TextChanged);
            // 
            // tBoxAddprtInv
            // 
            this.tBoxAddprtInv.Location = new System.Drawing.Point(105, 204);
            this.tBoxAddprtInv.Name = "tBoxAddprtInv";
            this.tBoxAddprtInv.Size = new System.Drawing.Size(155, 20);
            this.tBoxAddprtInv.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tBoxAddprtInv, "Requires a number");
            this.tBoxAddprtInv.TextChanged += new System.EventHandler(this.tBoxAddprtInv_TextChanged);
            // 
            // tBoxAddprtPrice
            // 
            this.tBoxAddprtPrice.Location = new System.Drawing.Point(105, 260);
            this.tBoxAddprtPrice.Name = "tBoxAddprtPrice";
            this.tBoxAddprtPrice.Size = new System.Drawing.Size(155, 20);
            this.tBoxAddprtPrice.TabIndex = 15;
            this.toolTip1.SetToolTip(this.tBoxAddprtPrice, "Requires a number");
            this.tBoxAddprtPrice.TextChanged += new System.EventHandler(this.tBoxAddprtPrice_TextChanged);
            // 
            // tBoxAddprtMax
            // 
            this.tBoxAddprtMax.Location = new System.Drawing.Point(85, 298);
            this.tBoxAddprtMax.Name = "tBoxAddprtMax";
            this.tBoxAddprtMax.Size = new System.Drawing.Size(76, 20);
            this.tBoxAddprtMax.TabIndex = 16;
            this.toolTip1.SetToolTip(this.tBoxAddprtMax, "Requires a number");
            this.tBoxAddprtMax.TextChanged += new System.EventHandler(this.tBoxAddprtMax_TextChanged);
            // 
            // tBoxAddprtMin
            // 
            this.tBoxAddprtMin.Location = new System.Drawing.Point(288, 298);
            this.tBoxAddprtMin.Name = "tBoxAddprtMin";
            this.tBoxAddprtMin.Size = new System.Drawing.Size(76, 20);
            this.tBoxAddprtMin.TabIndex = 17;
            this.toolTip1.SetToolTip(this.tBoxAddprtMin, "Requires a number");
            this.tBoxAddprtMin.TextChanged += new System.EventHandler(this.tBoxAddprtMin_TextChanged);
            // 
            // tBoxMachOrComp
            // 
            this.tBoxMachOrComp.Location = new System.Drawing.Point(127, 349);
            this.tBoxMachOrComp.Name = "tBoxMachOrComp";
            this.tBoxMachOrComp.Size = new System.Drawing.Size(155, 20);
            this.tBoxMachOrComp.TabIndex = 18;
            this.tBoxMachOrComp.TextChanged += new System.EventHandler(this.tBoxMachOrComp_TextChanged);
            // 
            // Addpart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.tBoxMachOrComp);
            this.Controls.Add(this.tBoxAddprtMin);
            this.Controls.Add(this.tBoxAddprtMax);
            this.Controls.Add(this.tBoxAddprtPrice);
            this.Controls.Add(this.tBoxAddprtInv);
            this.Controls.Add(this.tBoxAddprtName);
            this.Controls.Add(this.tBoxAddprtID);
            this.Controls.Add(this.buttonAddCacncel);
            this.Controls.Add(this.buttonAddSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPriceCost);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.radioAddprtOutsourced);
            this.Controls.Add(this.radioAddprtInHouse);
            this.Controls.Add(this.label1);
            this.Name = "Addpart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Addpart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAddprtInHouse;
        private System.Windows.Forms.RadioButton radioAddprtOutsourced;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPriceCost;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddSave;
        private System.Windows.Forms.Button buttonAddCacncel;
        private System.Windows.Forms.TextBox tBoxAddprtID;
        private System.Windows.Forms.TextBox tBoxAddprtName;
        private System.Windows.Forms.TextBox tBoxAddprtInv;
        private System.Windows.Forms.TextBox tBoxAddprtPrice;
        private System.Windows.Forms.TextBox tBoxAddprtMax;
        private System.Windows.Forms.TextBox tBoxAddprtMin;
        private System.Windows.Forms.TextBox tBoxMachOrComp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
    
}