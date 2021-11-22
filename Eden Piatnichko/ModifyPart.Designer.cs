
namespace Eden_Piatnichko
{
    partial class ModifyPart
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
            this.ModBoxMachOrComp = new System.Windows.Forms.TextBox();
            this.tBoxModprtMin = new System.Windows.Forms.TextBox();
            this.tBoxModprtMax = new System.Windows.Forms.TextBox();
            this.tBoxModprtPrice = new System.Windows.Forms.TextBox();
            this.tBoxModprtInv = new System.Windows.Forms.TextBox();
            this.tBoxModprtName = new System.Windows.Forms.TextBox();
            this.tBoxModprtID = new System.Windows.Forms.TextBox();
            this.buttonModprtCacncel = new System.Windows.Forms.Button();
            this.buttonModprtSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPriceCost = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.radioModprtOutsourced = new System.Windows.Forms.RadioButton();
            this.radioModprtInHouse = new System.Windows.Forms.RadioButton();
            this.labelModiftPart = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ModBoxMachOrComp
            // 
            this.ModBoxMachOrComp.Location = new System.Drawing.Point(139, 358);
            this.ModBoxMachOrComp.Name = "ModBoxMachOrComp";
            this.ModBoxMachOrComp.Size = new System.Drawing.Size(155, 20);
            this.ModBoxMachOrComp.TabIndex = 37;
            this.ModBoxMachOrComp.TextChanged += new System.EventHandler(this.tBoxMachOrComp_TextChanged);
            // 
            // tBoxModprtMin
            // 
            this.tBoxModprtMin.Location = new System.Drawing.Point(300, 307);
            this.tBoxModprtMin.Name = "tBoxModprtMin";
            this.tBoxModprtMin.Size = new System.Drawing.Size(76, 20);
            this.tBoxModprtMin.TabIndex = 36;
            this.toolTip2.SetToolTip(this.tBoxModprtMin, "Requires a number");
            this.tBoxModprtMin.TextChanged += new System.EventHandler(this.tBoxAddprtMin_TextChanged);
            // 
            // tBoxModprtMax
            // 
            this.tBoxModprtMax.Location = new System.Drawing.Point(97, 307);
            this.tBoxModprtMax.Name = "tBoxModprtMax";
            this.tBoxModprtMax.Size = new System.Drawing.Size(76, 20);
            this.tBoxModprtMax.TabIndex = 35;
            this.toolTip2.SetToolTip(this.tBoxModprtMax, "Requires a number");
            this.tBoxModprtMax.TextChanged += new System.EventHandler(this.tBoxAddprtMax_TextChanged);
            // 
            // tBoxModprtPrice
            // 
            this.tBoxModprtPrice.Location = new System.Drawing.Point(117, 269);
            this.tBoxModprtPrice.Name = "tBoxModprtPrice";
            this.tBoxModprtPrice.Size = new System.Drawing.Size(155, 20);
            this.tBoxModprtPrice.TabIndex = 34;
            this.toolTip2.SetToolTip(this.tBoxModprtPrice, "Requires a number");
            this.tBoxModprtPrice.TextChanged += new System.EventHandler(this.tBoxAddprtPrice_TextChanged);
            // 
            // tBoxModprtInv
            // 
            this.tBoxModprtInv.Location = new System.Drawing.Point(117, 213);
            this.tBoxModprtInv.Name = "tBoxModprtInv";
            this.tBoxModprtInv.Size = new System.Drawing.Size(155, 20);
            this.tBoxModprtInv.TabIndex = 33;
            this.toolTip2.SetToolTip(this.tBoxModprtInv, "Requires a number");
            this.tBoxModprtInv.TextChanged += new System.EventHandler(this.tBoxAddprtInv_TextChanged);
            // 
            // tBoxModprtName
            // 
            this.tBoxModprtName.Location = new System.Drawing.Point(117, 148);
            this.tBoxModprtName.Name = "tBoxModprtName";
            this.tBoxModprtName.Size = new System.Drawing.Size(155, 20);
            this.tBoxModprtName.TabIndex = 32;
            this.toolTip2.SetToolTip(this.tBoxModprtName, "Requires Text");
            this.tBoxModprtName.TextChanged += new System.EventHandler(this.tBoxAddprtName_TextChanged);
            // 
            // tBoxModprtID
            // 
            this.tBoxModprtID.Location = new System.Drawing.Point(117, 88);
            this.tBoxModprtID.Name = "tBoxModprtID";
            this.tBoxModprtID.ReadOnly = true;
            this.tBoxModprtID.Size = new System.Drawing.Size(155, 20);
            this.tBoxModprtID.TabIndex = 31;
            this.tBoxModprtID.TextChanged += new System.EventHandler(this.tBoxAddprtID_TextChanged);
            // 
            // buttonModprtCacncel
            // 
            this.buttonModprtCacncel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonModprtCacncel.Location = new System.Drawing.Point(435, 410);
            this.buttonModprtCacncel.Name = "buttonModprtCacncel";
            this.buttonModprtCacncel.Size = new System.Drawing.Size(75, 23);
            this.buttonModprtCacncel.TabIndex = 30;
            this.buttonModprtCacncel.Text = "Cancel";
            this.buttonModprtCacncel.UseVisualStyleBackColor = true;
            this.buttonModprtCacncel.Click += new System.EventHandler(this.buttonAddCacncel_Click);
            // 
            // buttonModprtSave
            // 
            this.buttonModprtSave.Location = new System.Drawing.Point(354, 410);
            this.buttonModprtSave.Name = "buttonModprtSave";
            this.buttonModprtSave.Size = new System.Drawing.Size(75, 23);
            this.buttonModprtSave.TabIndex = 29;
            this.buttonModprtSave.Text = "Save";
            this.buttonModprtSave.UseVisualStyleBackColor = true;
            this.buttonModprtSave.Click += new System.EventHandler(this.buttonAddSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(270, 310);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 27;
            this.labelMin.Text = "Min";
            this.labelMin.Click += new System.EventHandler(this.labelMin_Click);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(64, 310);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 26;
            this.labelMax.Text = "Max";
            this.labelMax.Click += new System.EventHandler(this.labelMax_Click);
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Location = new System.Drawing.Point(43, 272);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(60, 13);
            this.labelPriceCost.TabIndex = 25;
            this.labelPriceCost.Text = "Price/ Cost";
            this.labelPriceCost.Click += new System.EventHandler(this.labelPriceCost_Click);
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(43, 213);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 24;
            this.labelInventory.Text = "Inventory";
            this.labelInventory.Click += new System.EventHandler(this.labelInventory_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(43, 148);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(43, 88);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // radioModprtOutsourced
            // 
            this.radioModprtOutsourced.AutoSize = true;
            this.radioModprtOutsourced.Location = new System.Drawing.Point(354, 21);
            this.radioModprtOutsourced.Name = "radioModprtOutsourced";
            this.radioModprtOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioModprtOutsourced.TabIndex = 21;
            this.radioModprtOutsourced.TabStop = true;
            this.radioModprtOutsourced.Text = "Outsourced";
            this.radioModprtOutsourced.UseVisualStyleBackColor = true;
            this.radioModprtOutsourced.CheckedChanged += new System.EventHandler(this.radioAddprtOutsourced_CheckedChanged);
            // 
            // radioModprtInHouse
            // 
            this.radioModprtInHouse.AutoSize = true;
            this.radioModprtInHouse.Location = new System.Drawing.Point(193, 21);
            this.radioModprtInHouse.Name = "radioModprtInHouse";
            this.radioModprtInHouse.Size = new System.Drawing.Size(68, 17);
            this.radioModprtInHouse.TabIndex = 20;
            this.radioModprtInHouse.TabStop = true;
            this.radioModprtInHouse.Text = "In-House";
            this.radioModprtInHouse.UseVisualStyleBackColor = true;
            this.radioModprtInHouse.CheckedChanged += new System.EventHandler(this.radioAddprtInHouse_CheckedChanged);
            // 
            // labelModiftPart
            // 
            this.labelModiftPart.AutoSize = true;
            this.labelModiftPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModiftPart.Location = new System.Drawing.Point(12, 9);
            this.labelModiftPart.Name = "labelModiftPart";
            this.labelModiftPart.Size = new System.Drawing.Size(99, 20);
            this.labelModiftPart.TabIndex = 19;
            this.labelModiftPart.Text = "Modify Part";
            this.labelModiftPart.Click += new System.EventHandler(this.label1_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.ModBoxMachOrComp);
            this.Controls.Add(this.tBoxModprtMin);
            this.Controls.Add(this.tBoxModprtMax);
            this.Controls.Add(this.tBoxModprtPrice);
            this.Controls.Add(this.tBoxModprtInv);
            this.Controls.Add(this.tBoxModprtName);
            this.Controls.Add(this.tBoxModprtID);
            this.Controls.Add(this.buttonModprtCacncel);
            this.Controls.Add(this.buttonModprtSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPriceCost);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.radioModprtOutsourced);
            this.Controls.Add(this.radioModprtInHouse);
            this.Controls.Add(this.labelModiftPart);
            this.Name = "ModifyPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyPart";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ModBoxMachOrComp;
        private System.Windows.Forms.TextBox tBoxModprtMin;
        private System.Windows.Forms.TextBox tBoxModprtMax;
        private System.Windows.Forms.TextBox tBoxModprtPrice;
        private System.Windows.Forms.TextBox tBoxModprtInv;
        private System.Windows.Forms.TextBox tBoxModprtName;
        private System.Windows.Forms.TextBox tBoxModprtID;
        private System.Windows.Forms.Button buttonModprtCacncel;
        private System.Windows.Forms.Button buttonModprtSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelPriceCost;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.RadioButton radioModprtOutsourced;
        private System.Windows.Forms.RadioButton radioModprtInHouse;
        private System.Windows.Forms.Label labelModiftPart;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}