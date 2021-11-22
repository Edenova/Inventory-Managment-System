
namespace Eden_Piatnichko
{
    partial class AddProduct
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
            this.tBoxAddprodMin = new System.Windows.Forms.TextBox();
            this.tBoxAddprodMax = new System.Windows.Forms.TextBox();
            this.tBoxAddprodPrice = new System.Windows.Forms.TextBox();
            this.tBoxAddprodInv = new System.Windows.Forms.TextBox();
            this.tBoxAddprodName = new System.Windows.Forms.TextBox();
            this.tBoxAddprodID = new System.Windows.Forms.TextBox();
            this.buttonCacncel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAddProd = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchProd = new System.Windows.Forms.TextBox();
            this.addProdGridView1 = new System.Windows.Forms.DataGridView();
            this.addProdGridView2 = new System.Windows.Forms.DataGridView();
            this.labelCanidateParts = new System.Windows.Forms.Label();
            this.labelAssociatedParts = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addProdGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProdGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxAddprodMin
            // 
            this.tBoxAddprodMin.Location = new System.Drawing.Point(300, 307);
            this.tBoxAddprodMin.Name = "tBoxAddprodMin";
            this.tBoxAddprodMin.Size = new System.Drawing.Size(76, 20);
            this.tBoxAddprodMin.TabIndex = 36;
            this.tBoxAddprodMin.TextChanged += new System.EventHandler(this.tBoxAddprodMin_TextChanged);
            // 
            // tBoxAddprodMax
            // 
            this.tBoxAddprodMax.Location = new System.Drawing.Point(97, 307);
            this.tBoxAddprodMax.Name = "tBoxAddprodMax";
            this.tBoxAddprodMax.Size = new System.Drawing.Size(76, 20);
            this.tBoxAddprodMax.TabIndex = 35;
            this.tBoxAddprodMax.TextChanged += new System.EventHandler(this.tBoxAddprodMax_TextChanged);
            // 
            // tBoxAddprodPrice
            // 
            this.tBoxAddprodPrice.Location = new System.Drawing.Point(117, 269);
            this.tBoxAddprodPrice.Name = "tBoxAddprodPrice";
            this.tBoxAddprodPrice.Size = new System.Drawing.Size(155, 20);
            this.tBoxAddprodPrice.TabIndex = 34;
            this.tBoxAddprodPrice.TextChanged += new System.EventHandler(this.tBoxAddprodPrice_TextChanged);
            // 
            // tBoxAddprodInv
            // 
            this.tBoxAddprodInv.Location = new System.Drawing.Point(117, 213);
            this.tBoxAddprodInv.Name = "tBoxAddprodInv";
            this.tBoxAddprodInv.Size = new System.Drawing.Size(155, 20);
            this.tBoxAddprodInv.TabIndex = 33;
            this.tBoxAddprodInv.TextChanged += new System.EventHandler(this.tBoxAddprodInv_TextChanged);
            // 
            // tBoxAddprodName
            // 
            this.tBoxAddprodName.Location = new System.Drawing.Point(117, 148);
            this.tBoxAddprodName.Name = "tBoxAddprodName";
            this.tBoxAddprodName.Size = new System.Drawing.Size(155, 20);
            this.tBoxAddprodName.TabIndex = 32;
            this.tBoxAddprodName.TextChanged += new System.EventHandler(this.tBoxAddprodName_TextChanged);
            // 
            // tBoxAddprodID
            // 
            this.tBoxAddprodID.Location = new System.Drawing.Point(117, 88);
            this.tBoxAddprodID.Name = "tBoxAddprodID";
            this.tBoxAddprodID.Size = new System.Drawing.Size(155, 20);
            this.tBoxAddprodID.TabIndex = 31;
            this.tBoxAddprodID.TextChanged += new System.EventHandler(this.tBoxAddprodID_TextChanged);
            // 
            // buttonCacncel
            // 
            this.buttonCacncel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCacncel.Location = new System.Drawing.Point(957, 650);
            this.buttonCacncel.Name = "buttonCacncel";
            this.buttonCacncel.Size = new System.Drawing.Size(75, 23);
            this.buttonCacncel.TabIndex = 30;
            this.buttonCacncel.Text = "Cancel";
            this.buttonCacncel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(876, 650);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(270, 310);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 27;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(64, 310);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 26;
            this.labelMax.Text = "Max";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(43, 272);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 25;
            this.labelPrice.Text = "Price";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(43, 213);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 24;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(43, 148);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(43, 88);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "ID";
            // 
            // labelAddProd
            // 
            this.labelAddProd.AutoSize = true;
            this.labelAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProd.Location = new System.Drawing.Point(12, 9);
            this.labelAddProd.Name = "labelAddProd";
            this.labelAddProd.Size = new System.Drawing.Size(108, 20);
            this.labelAddProd.TabIndex = 19;
            this.labelAddProd.Text = "Add Product";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(707, 66);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 37;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSearchProd
            // 
            this.textBoxSearchProd.Location = new System.Drawing.Point(788, 66);
            this.textBoxSearchProd.Name = "textBoxSearchProd";
            this.textBoxSearchProd.Size = new System.Drawing.Size(244, 20);
            this.textBoxSearchProd.TabIndex = 38;
            // 
            // addProdGridView1
            // 
            this.addProdGridView1.AllowUserToAddRows = false;
            this.addProdGridView1.AllowUserToDeleteRows = false;
            this.addProdGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProdGridView1.Location = new System.Drawing.Point(565, 131);
            this.addProdGridView1.Name = "addProdGridView1";
            this.addProdGridView1.ReadOnly = true;
            this.addProdGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProdGridView1.Size = new System.Drawing.Size(467, 173);
            this.addProdGridView1.TabIndex = 39;
            // 
            // addProdGridView2
            // 
            this.addProdGridView2.AllowUserToAddRows = false;
            this.addProdGridView2.AllowUserToDeleteRows = false;
            this.addProdGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProdGridView2.Location = new System.Drawing.Point(565, 370);
            this.addProdGridView2.Name = "addProdGridView2";
            this.addProdGridView2.ReadOnly = true;
            this.addProdGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProdGridView2.Size = new System.Drawing.Size(467, 173);
            this.addProdGridView2.TabIndex = 40;
            // 
            // labelCanidateParts
            // 
            this.labelCanidateParts.AutoSize = true;
            this.labelCanidateParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCanidateParts.Location = new System.Drawing.Point(562, 105);
            this.labelCanidateParts.Name = "labelCanidateParts";
            this.labelCanidateParts.Size = new System.Drawing.Size(132, 20);
            this.labelCanidateParts.TabIndex = 41;
            this.labelCanidateParts.Text = "All canidate Parts";
            // 
            // labelAssociatedParts
            // 
            this.labelAssociatedParts.AutoSize = true;
            this.labelAssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssociatedParts.Location = new System.Drawing.Point(561, 347);
            this.labelAssociatedParts.Name = "labelAssociatedParts";
            this.labelAssociatedParts.Size = new System.Drawing.Size(249, 20);
            this.labelAssociatedParts.TabIndex = 42;
            this.labelAssociatedParts.Text = "Parts Associated with this Product";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(957, 319);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 43;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(957, 566);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 685);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAssociatedParts);
            this.Controls.Add(this.labelCanidateParts);
            this.Controls.Add(this.addProdGridView2);
            this.Controls.Add(this.addProdGridView1);
            this.Controls.Add(this.textBoxSearchProd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.tBoxAddprodMin);
            this.Controls.Add(this.tBoxAddprodMax);
            this.Controls.Add(this.tBoxAddprodPrice);
            this.Controls.Add(this.tBoxAddprodInv);
            this.Controls.Add(this.tBoxAddprodName);
            this.Controls.Add(this.tBoxAddprodID);
            this.Controls.Add(this.buttonCacncel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelAddProd);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addProdGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProdGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBoxAddprodMin;
        private System.Windows.Forms.TextBox tBoxAddprodMax;
        private System.Windows.Forms.TextBox tBoxAddprodPrice;
        private System.Windows.Forms.TextBox tBoxAddprodInv;
        private System.Windows.Forms.TextBox tBoxAddprodName;
        private System.Windows.Forms.TextBox tBoxAddprodID;
        private System.Windows.Forms.Button buttonCacncel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAddProd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchProd;
        private System.Windows.Forms.DataGridView addProdGridView1;
        private System.Windows.Forms.DataGridView addProdGridView2;
        private System.Windows.Forms.Label labelCanidateParts;
        private System.Windows.Forms.Label labelAssociatedParts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
    }
}