using System.Xml.Linq;

namespace ProductList
{
    public partial class Form1 : Form
    {
        private ProductManager manager = new ProductManager();
        private Product selectedProduct = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void RefreshProductGrid()
        {
            // Sort products by price (ascending)
            var list = manager.GetallProducts();

            // Bind to DataGridView
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = list;

            // Update total
            double total = manager.GetTotalPrice(list);
            lblTotal.Text = $"Total: {total:C}";

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string category = CategortyTxt.Text.Trim();
                string name = Nametxt.Text.Trim();
                double price = (double)PriceNum.Value;
                if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Category and Name cannot be empty.");
                    return;
                }
                manager.AddProduct(new Product(category, name, price));
                RefreshProductGrid();

                //  Clear inputs after adding
                CategortyTxt.Clear();
                Nametxt.Clear();
                PriceNum.Value = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ShowBTN_Click(object sender, EventArgs e)
        {
            RefreshProductGrid();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim().ToLower();
            var list = string.IsNullOrEmpty(term)
                ? manager.GetallProducts() : manager.SearchProduct(term);

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = list;

            double total = manager.GetTotalPrice(list);
            lblTotal.Text = $"Total: {total:C}";
            txtSearch.Clear();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }
            // Get selected product
            Product selectedProduct = (Product)dgvProducts.SelectedRows[0].DataBoundItem;

            // Confirm deletion
            var result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                manager.RemoveProduct(selectedProduct);
                RefreshProductGrid();

                selectedProduct = null; // reset edit state

                // Clear input fields
                CategortyTxt.Clear();
                Nametxt.Clear();
                PriceNum.Value = 0;
                //  Remove selection
                dgvProducts.ClearSelection();
            }


        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Check if a product is selected
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }
            try
            {
                string category = CategortyTxt.Text.Trim();
                string name = Nametxt.Text.Trim();
                double price = (double)PriceNum.Value;
                //  Validate input
                if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Category and Name cannot be empty.");
                    return;
                }
                //  Update the SAME object
                selectedProduct.Category = category;
                selectedProduct.Name = name;
                selectedProduct.Price = price;

                //  Refresh the grid
                RefreshProductGrid();

                // Reset UI
                selectedProduct = null;
                CategortyTxt.Clear();
                Nametxt.Clear();
                PriceNum.Value = 0;
                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedProduct = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;

            CategortyTxt.Text = selectedProduct.Category;
            Nametxt.Text = selectedProduct.Name;
            PriceNum.Value = (decimal)selectedProduct.Price;
        }
    }
}
