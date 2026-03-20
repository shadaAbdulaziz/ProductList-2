namespace ProductList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CategortyTxt = new TextBox();
            Nametxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddProductBtn = new Button();
            ShowBTN = new Button();
            SearchBtn = new Button();
            PriceNum = new NumericUpDown();
            dgvProducts = new DataGridView();
            lblTotal = new Label();
            label5 = new Label();
            txtSearch = new TextBox();
            label4 = new Label();
            DelBtn = new Button();
            EditBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PriceNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // CategortyTxt
            // 
            CategortyTxt.Location = new Point(285, 61);
            CategortyTxt.Name = "CategortyTxt";
            CategortyTxt.Size = new Size(304, 47);
            CategortyTxt.TabIndex = 0;
            CategortyTxt.TextChanged += textBox1_TextChanged;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(285, 151);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(304, 47);
            Nametxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 61);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 3;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 157);
            label2.Name = "label2";
            label2.Size = new Size(209, 41);
            label2.TabIndex = 4;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 245);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 5;
            label3.Text = "Price";
            label3.Click += label3_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(331, 336);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(268, 72);
            AddProductBtn.TabIndex = 6;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // ShowBTN
            // 
            ShowBTN.Location = new Point(36, 336);
            ShowBTN.Name = "ShowBTN";
            ShowBTN.Size = new Size(265, 72);
            ShowBTN.TabIndex = 7;
            ShowBTN.Text = "Show Products";
            ShowBTN.UseVisualStyleBackColor = true;
            ShowBTN.Click += ShowBTN_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(397, 744);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(214, 76);
            SearchBtn.TabIndex = 8;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // PriceNum
            // 
            PriceNum.Location = new Point(285, 239);
            PriceNum.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            PriceNum.Name = "PriceNum";
            PriceNum.Size = new Size(314, 47);
            PriceNum.TabIndex = 9;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(631, 19);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 102;
            dgvProducts.Size = new Size(788, 738);
            dgvProducts.TabIndex = 10;
            dgvProducts.CellClick += dgvProducts_CellContentClick;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1137, 779);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 41);
            lblTotal.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(842, 779);
            label5.Name = "label5";
            label5.Size = new Size(153, 41);
            label5.TabIndex = 12;
            label5.Text = "Total Price";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(32, 773);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(359, 47);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += textBox1_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 720);
            label4.Name = "label4";
            label4.Size = new Size(359, 41);
            label4.TabIndex = 14;
            label4.Text = "Search Products by Name";
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(36, 482);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(265, 58);
            DelBtn.TabIndex = 15;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(346, 482);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(265, 58);
            EditBtn.TabIndex = 16;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 871);
            Controls.Add(EditBtn);
            Controls.Add(DelBtn);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(lblTotal);
            Controls.Add(dgvProducts);
            Controls.Add(PriceNum);
            Controls.Add(SearchBtn);
            Controls.Add(ShowBTN);
            Controls.Add(AddProductBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nametxt);
            Controls.Add(CategortyTxt);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PriceNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CategortyTxt;
        private TextBox Nametxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddProductBtn;
        private Button ShowBTN;
        private Button SearchBtn;
        private NumericUpDown PriceNum;
        private DataGridView dgvProducts;
        private Label lblTotal;
        private Label label5;
        private TextBox txtSearch;
        private Label label4;
        private Button DelBtn;
        private Button EditBtn;
    }
}
