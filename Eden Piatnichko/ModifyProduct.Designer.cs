
namespace Eden_Piatnichko
{
    partial class ModifyProduct
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
            this.buttonDeleteProdMod = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCanidateParts = new System.Windows.Forms.Label();
            this.modProdGridView2 = new System.Windows.Forms.DataGridView();
            this.modProdGridView1 = new System.Windows.Forms.DataGridView();
            this.tBoxSearchModProd = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tBoxModProdMin = new System.Windows.Forms.TextBox();
            this.tBoxModProdMax = new System.Windows.Forms.TextBox();
            this.tBoxModProdPrice = new System.Windows.Forms.TextBox();
            this.tBoxModProdInv = new System.Windows.Forms.TextBox();
            this.tBoxModProdName = new System.Windows.Forms.TextBox();
            this.tBoxModProdID = new System.Windows.Forms.TextBox();
            this.buttonCacncelProdMod = new System.Windows.Forms.Button();
            this.buttonSaveProdMod = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelModProd = new System.Windows.Forms.Label();
            this.labelAssociatedParts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modProdGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProdGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteProdMod
            // 
            this.buttonDeleteProdMod.Location = new System.Drawing.Point(954, 565);
            this.buttonDeleteProdMod.Name = "buttonDeleteProdMod";
            this.buttonDeleteProdMod.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProdMod.TabIndex = 66;
            this.buttonDeleteProdMod.Text = "Delete";
            this.buttonDeleteProdMod.UseVisualStyleBackColor = true;
            this.buttonDeleteProdMod.Click += new System.EventHandler(this.buttonDeleteProdMod_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(954, 318);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 65;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCanidateParts
            // 
            this.labelCanidateParts.AutoSize = true;
            this.labelCanidateParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCanidateParts.Location = new System.Drawing.Point(559, 104);
            this.labelCanidateParts.Name = "labelCanidateParts";
            this.labelCanidateParts.Size = new System.Drawing.Size(132, 20);
            this.labelCanidateParts.TabIndex = 64;
            this.labelCanidateParts.Text = "All canidate Parts";
            // 
            // modProdGridView2
            // 
            this.modProdGridView2.AllowUserToAddRows = false;
            this.modProdGridView2.AllowUserToDeleteRows = false;
            this.modProdGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProdGridView2.Location = new System.Drawing.Point(562, 369);
            this.modProdGridView2.Name = "modProdGridView2";
            this.modProdGridView2.ReadOnly = true;
            this.modProdGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modProdGridView2.Size = new System.Drawing.Size(467, 173);
            this.modProdGridView2.TabIndex = 63;
            // 
            // modProdGridView1
            // 
            this.modProdGridView1.AllowUserToAddRows = false;
            this.modProdGridView1.AllowUserToDeleteRows = false;
            this.modProdGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProdGridView1.Location = new System.Drawing.Point(562, 130);
            this.modProdGridView1.Name = "modProdGridView1";
            this.modProdGridView1.ReadOnly = true;
            this.modProdGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modProdGridView1.Size = new System.Drawing.Size(467, 173);
            this.modProdGridView1.TabIndex = 62;
            // 
            // tBoxSearchModProd
            // 
            this.tBoxSearchModProd.Location = new System.Drawing.Point(785, 65);
            this.tBoxSearchModProd.Name = "tBoxSearchModProd";
            this.tBoxSearchModProd.Size = new System.Drawing.Size(244, 20);
            this.tBoxSearchModProd.TabIndex = 61;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(704, 65);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 60;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // tBoxModProdMin
            // 
            this.tBoxModProdMin.Location = new System.Drawing.Point(297, 306);
            this.tBoxModProdMin.Name = "tBoxModProdMin";
            this.tBoxModProdMin.Size = new System.Drawing.Size(76, 20);
            this.tBoxModProdMin.TabIndex = 59;
            this.tBoxModProdMin.TextChanged += new System.EventHandler(this.tBoxModProdMin_TextChanged);
            // 
            // tBoxModProdMax
            // 
            this.tBoxModProdMax.Location = new System.Drawing.Point(94, 306);
            this.tBoxModProdMax.Name = "tBoxModProdMax";
            this.tBoxModProdMax.Size = new System.Drawing.Size(76, 20);
            this.tBoxModProdMax.TabIndex = 58;
            this.tBoxModProdMax.TextChanged += new System.EventHandler(this.tBoxModProdMax_TextChanged);
            // 
            // tBoxModProdPrice
            // 
            this.tBoxModProdPrice.Location = new System.Drawing.Point(114, 268);
            this.tBoxModProdPrice.Name = "tBoxModProdPrice";
            this.tBoxModProdPrice.Size = new System.Drawing.Size(155, 20);
            this.tBoxModProdPrice.TabIndex = 57;
            this.tBoxModProdPrice.TextChanged += new System.EventHandler(this.tBoxModProdPrice_TextChanged);
            // 
            // tBoxModProdInv
            // 
            this.tBoxModProdInv.Location = new System.Drawing.Point(114, 212);
            this.tBoxModProdInv.Name = "tBoxModProdInv";
            this.tBoxModProdInv.Size = new System.Drawing.Size(155, 20);
            this.tBoxModProdInv.TabIndex = 56;
            this.tBoxModProdInv.TextChanged += new System.EventHandler(this.tBoxModProdInv_TextChanged);
            // 
            // tBoxModProdName
            // 
            this.tBoxModProdName.Location = new System.Drawing.Point(114, 147);
            this.tBoxModProdName.Name = "tBoxModProdName";
            this.tBoxModProdName.Size = new System.Drawing.Size(155, 20);
            this.tBoxModProdName.TabIndex = 55;
            this.tBoxModProdName.TextChanged += new System.EventHandler(this.tBoxModProdName_TextChanged);
            // 
            // tBoxModProdID
            // 
            this.tBoxModProdID.Location = new System.Drawing.Point(114, 87);
            this.tBoxModProdID.Name = "tBoxModProdID";
            this.tBoxModProdID.ReadOnly = true;
            this.tBoxModProdID.Size = new System.Drawing.Size(155, 20);
            this.tBoxModProdID.TabIndex = 54;
            // 
            // buttonCacncelProdMod
            // 
            this.buttonCacncelProdMod.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCacncelProdMod.Location = new System.Drawing.Point(954, 649);
            this.buttonCacncelProdMod.Name = "buttonCacncelProdMod";
            this.buttonCacncelProdMod.Size = new System.Drawing.Size(75, 23);
            this.buttonCacncelProdMod.TabIndex = 53;
            this.buttonCacncelProdMod.Text = "Cancel";
            this.buttonCacncelProdMod.UseVisualStyleBackColor = true;
            // 
            // buttonSaveProdMod
            // 
            this.buttonSaveProdMod.Location = new System.Drawing.Point(873, 649);
            this.buttonSaveProdMod.Name = "buttonSaveProdMod";
            this.buttonSaveProdMod.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveProdMod.TabIndex = 52;
            this.buttonSaveProdMod.Text = "Save";
            this.buttonSaveProdMod.UseVisualStyleBackColor = true;
            this.buttonSaveProdMod.Click += new System.EventHandler(this.buttonSaveProdMod_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(267, 309);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 51;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(61, 309);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 50;
            this.labelMax.Text = "Max";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(40, 271);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 49;
            this.labelPrice.Text = "Price";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(40, 212);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 48;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 147);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 47;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(40, 87);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 46;
            this.labelID.Text = "ID";
            // 
            // labelModProd
            // 
            this.labelModProd.AutoSize = true;
            this.labelModProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModProd.Location = new System.Drawing.Point(9, 8);
            this.labelModProd.Name = "labelModProd";
            this.labelModProd.Size = new System.Drawing.Size(128, 20);
            this.labelModProd.TabIndex = 45;
            this.labelModProd.Text = "Modify Product";
            // 
            // labelAssociatedParts
            // 
            this.labelAssociatedParts.AutoSize = true;
            this.labelAssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssociatedParts.Location = new System.Drawing.Point(559, 346);
            this.labelAssociatedParts.Name = "labelAssociatedParts";
            this.labelAssociatedParts.Size = new System.Drawing.Size(249, 20);
            this.labelAssociatedParts.TabIndex = 67;
            this.labelAssociatedParts.Text = "Parts Associated with this Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 697);
            this.Controls.Add(this.labelAssociatedParts);
            this.Controls.Add(this.buttonDeleteProdMod);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCanidateParts);
            this.Controls.Add(this.modProdGridView2);
            this.Controls.Add(this.modProdGridView1);
            this.Controls.Add(this.tBoxSearchModProd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.tBoxModProdMin);
            this.Controls.Add(this.tBoxModProdMax);
            this.Controls.Add(this.tBoxModProdPrice);
            this.Controls.Add(this.tBoxModProdInv);
            this.Controls.Add(this.tBoxModProdName);
            this.Controls.Add(this.tBoxModProdID);
            this.Controls.Add(this.buttonCacncelProdMod);
            this.Controls.Add(this.buttonSaveProdMod);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelModProd);
            this.Name = "ModifyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyProduct";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modProdGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProdGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteProdMod;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCanidateParts;
        private System.Windows.Forms.DataGridView modProdGridView2;
        private System.Windows.Forms.DataGridView modProdGridView1;
        private System.Windows.Forms.TextBox tBoxSearchModProd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox tBoxModProdMin;
        private System.Windows.Forms.TextBox tBoxModProdMax;
        private System.Windows.Forms.TextBox tBoxModProdPrice;
        private System.Windows.Forms.TextBox tBoxModProdInv;
        private System.Windows.Forms.TextBox tBoxModProdName;
        private System.Windows.Forms.TextBox tBoxModProdID;
        private System.Windows.Forms.Button buttonCacncelProdMod;
        private System.Windows.Forms.Button buttonSaveProdMod;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelModProd;
        private System.Windows.Forms.Label labelAssociatedParts;
    }
}