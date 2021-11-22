
namespace Eden_Piatnichko
{
    partial class Form1
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
            this.Header = new System.Windows.Forms.Label();
            this.SearchParts = new System.Windows.Forms.Button();
            this.SearchProducts = new System.Windows.Forms.Button();
            this.searchBoxProd = new System.Windows.Forms.TextBox();
            this.SearchBoxParts = new System.Windows.Forms.TextBox();
            this.Parts = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.Label();
            this.Addbtn_Parts = new System.Windows.Forms.Button();
            this.Modifybtn_parts = new System.Windows.Forms.Button();
            this.Deletebtn_parts = new System.Windows.Forms.Button();
            this.Addbtn_Prod = new System.Windows.Forms.Button();
            this.Modifybtn_prod = new System.Windows.Forms.Button();
            this.Deletebtn_prod = new System.Windows.Forms.Button();
            this.exiBbtn = new System.Windows.Forms.Button();
            this.mainPrtGridView = new System.Windows.Forms.DataGridView();
            this.mainProdGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainPrtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProdGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(285, 25);
            this.Header.TabIndex = 0;
            this.Header.Text = "Inventory Managment Sytem";
            this.Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchParts
            // 
            this.SearchParts.Location = new System.Drawing.Point(248, 113);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(75, 23);
            this.SearchParts.TabIndex = 1;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            this.SearchParts.Click += new System.EventHandler(this.SearchParts_Click);
            // 
            // SearchProducts
            // 
            this.SearchProducts.Location = new System.Drawing.Point(940, 116);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(75, 23);
            this.SearchProducts.TabIndex = 2;
            this.SearchProducts.Text = "Search";
            this.SearchProducts.UseVisualStyleBackColor = true;
            this.SearchProducts.Click += new System.EventHandler(this.SearchProducts_Click);
            // 
            // searchBoxProd
            // 
            this.searchBoxProd.Location = new System.Drawing.Point(1021, 116);
            this.searchBoxProd.Name = "searchBoxProd";
            this.searchBoxProd.Size = new System.Drawing.Size(174, 20);
            this.searchBoxProd.TabIndex = 3;
            // 
            // SearchBoxParts
            // 
            this.SearchBoxParts.Location = new System.Drawing.Point(329, 113);
            this.SearchBoxParts.Name = "SearchBoxParts";
            this.SearchBoxParts.Size = new System.Drawing.Size(174, 20);
            this.SearchBoxParts.TabIndex = 4;
            // 
            // Parts
            // 
            this.Parts.AutoSize = true;
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts.Location = new System.Drawing.Point(34, 144);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(51, 24);
            this.Parts.TabIndex = 5;
            this.Parts.Text = "Parts";
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.Location = new System.Drawing.Point(715, 144);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(84, 24);
            this.Products.TabIndex = 6;
            this.Products.Text = "Products";
            // 
            // Addbtn_Parts
            // 
            this.Addbtn_Parts.Location = new System.Drawing.Point(345, 431);
            this.Addbtn_Parts.Name = "Addbtn_Parts";
            this.Addbtn_Parts.Size = new System.Drawing.Size(54, 30);
            this.Addbtn_Parts.TabIndex = 9;
            this.Addbtn_Parts.Text = "Add";
            this.Addbtn_Parts.UseVisualStyleBackColor = true;
            this.Addbtn_Parts.Click += new System.EventHandler(this.Addbtn_Parts_Click);
            // 
            // Modifybtn_parts
            // 
            this.Modifybtn_parts.Location = new System.Drawing.Point(405, 431);
            this.Modifybtn_parts.Name = "Modifybtn_parts";
            this.Modifybtn_parts.Size = new System.Drawing.Size(54, 30);
            this.Modifybtn_parts.TabIndex = 10;
            this.Modifybtn_parts.Text = "Modify";
            this.Modifybtn_parts.UseVisualStyleBackColor = true;
            this.Modifybtn_parts.Click += new System.EventHandler(this.Modifybtn_parts_Click);
            // 
            // Deletebtn_parts
            // 
            this.Deletebtn_parts.Location = new System.Drawing.Point(465, 431);
            this.Deletebtn_parts.Name = "Deletebtn_parts";
            this.Deletebtn_parts.Size = new System.Drawing.Size(54, 30);
            this.Deletebtn_parts.TabIndex = 11;
            this.Deletebtn_parts.Text = "Delete";
            this.Deletebtn_parts.UseVisualStyleBackColor = true;
            this.Deletebtn_parts.Click += new System.EventHandler(this.Deletebtn_parts_Click);
            // 
            // Addbtn_Prod
            // 
            this.Addbtn_Prod.Location = new System.Drawing.Point(1021, 431);
            this.Addbtn_Prod.Name = "Addbtn_Prod";
            this.Addbtn_Prod.Size = new System.Drawing.Size(54, 30);
            this.Addbtn_Prod.TabIndex = 12;
            this.Addbtn_Prod.Text = "Add";
            this.Addbtn_Prod.UseVisualStyleBackColor = true;
            this.Addbtn_Prod.Click += new System.EventHandler(this.Addbtn_Prod_Click);
            // 
            // Modifybtn_prod
            // 
            this.Modifybtn_prod.Location = new System.Drawing.Point(1081, 431);
            this.Modifybtn_prod.Name = "Modifybtn_prod";
            this.Modifybtn_prod.Size = new System.Drawing.Size(54, 30);
            this.Modifybtn_prod.TabIndex = 13;
            this.Modifybtn_prod.Text = "Modify";
            this.Modifybtn_prod.UseVisualStyleBackColor = true;
            this.Modifybtn_prod.Click += new System.EventHandler(this.Modifybtn_prod_Click);
            // 
            // Deletebtn_prod
            // 
            this.Deletebtn_prod.Location = new System.Drawing.Point(1141, 431);
            this.Deletebtn_prod.Name = "Deletebtn_prod";
            this.Deletebtn_prod.Size = new System.Drawing.Size(54, 30);
            this.Deletebtn_prod.TabIndex = 14;
            this.Deletebtn_prod.Text = "Delete";
            this.Deletebtn_prod.UseVisualStyleBackColor = true;
            this.Deletebtn_prod.Click += new System.EventHandler(this.Deletebtn_prod_Click);
            // 
            // exiBbtn
            // 
            this.exiBbtn.Location = new System.Drawing.Point(1132, 507);
            this.exiBbtn.Name = "exiBbtn";
            this.exiBbtn.Size = new System.Drawing.Size(54, 30);
            this.exiBbtn.TabIndex = 15;
            this.exiBbtn.Text = "Exit";
            this.exiBbtn.UseVisualStyleBackColor = true;
            this.exiBbtn.Click += new System.EventHandler(this.exiBbtn_Click);
            // 
            // mainPrtGridView
            // 
            this.mainPrtGridView.AllowUserToAddRows = false;
            this.mainPrtGridView.AllowUserToDeleteRows = false;
            this.mainPrtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPrtGridView.Location = new System.Drawing.Point(17, 171);
            this.mainPrtGridView.MultiSelect = false;
            this.mainPrtGridView.Name = "mainPrtGridView";
            this.mainPrtGridView.ReadOnly = true;
            this.mainPrtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainPrtGridView.Size = new System.Drawing.Size(586, 222);
            this.mainPrtGridView.TabIndex = 16;
            // 
            // mainProdGridView
            // 
            this.mainProdGridView.AllowUserToAddRows = false;
            this.mainProdGridView.AllowUserToDeleteRows = false;
            this.mainProdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProdGridView.Location = new System.Drawing.Point(693, 171);
            this.mainProdGridView.MultiSelect = false;
            this.mainProdGridView.Name = "mainProdGridView";
            this.mainProdGridView.ReadOnly = true;
            this.mainProdGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProdGridView.Size = new System.Drawing.Size(568, 222);
            this.mainProdGridView.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 573);
            this.Controls.Add(this.mainProdGridView);
            this.Controls.Add(this.mainPrtGridView);
            this.Controls.Add(this.exiBbtn);
            this.Controls.Add(this.Deletebtn_prod);
            this.Controls.Add(this.Modifybtn_prod);
            this.Controls.Add(this.Addbtn_Prod);
            this.Controls.Add(this.Deletebtn_parts);
            this.Controls.Add(this.Modifybtn_parts);
            this.Controls.Add(this.Addbtn_Parts);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.SearchBoxParts);
            this.Controls.Add(this.searchBoxProd);
            this.Controls.Add(this.SearchProducts);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.Header);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPrtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProdGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.Button SearchProducts;
        private System.Windows.Forms.TextBox searchBoxProd;
        private System.Windows.Forms.TextBox SearchBoxParts;
        private System.Windows.Forms.Label Parts;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.Button Addbtn_Parts;
        private System.Windows.Forms.Button Modifybtn_parts;
        private System.Windows.Forms.Button Deletebtn_parts;
        private System.Windows.Forms.Button Addbtn_Prod;
        private System.Windows.Forms.Button Modifybtn_prod;
        private System.Windows.Forms.Button Deletebtn_prod;
        private System.Windows.Forms.Button exiBbtn;
        private System.Windows.Forms.DataGridView mainPrtGridView;
        private System.Windows.Forms.DataGridView mainProdGridView;
    }
}

