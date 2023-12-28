using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UtangApp
{
	public partial class AddProductPage : Form
	{
		int id = 0;
		Database database = new Database();

		public AddProductPage()
		{
			InitializeComponent();
		}

		private void AddProductPage_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'utang_dbDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.utang_dbDataSet.product);

			database.ReadData("SELECT * FROM product", product_dataGridView);

			product_dataGridView.Rows[0].Selected = true;

			id = Convert.ToInt32(product_dataGridView.SelectedRows[0].Cells[0].Value);

		}

		private void AddProductPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void back_btn_Click(object sender, EventArgs e)
		{
			Homepage homepage = new Homepage();
			homepage.Show();
			homepage.Location = this.Location;

			this.Hide();
		}

		private void delete_btn_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(product_dataGridView.SelectedRows[0].Cells[0].Value);


			database.DeleteData("product_id", id, "product");

			database.ReadData("SELECT * FROM product", product_dataGridView);
		}

		private void product_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Check if the double-clicked cell is valid (not the header and within the row bounds)
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				// Get the data from the selected row based on the double-clicked cell
				string selectedName = Convert.ToString(product_dataGridView.Rows[e.RowIndex].Cells[1].Value);
				string selectedPrice = Convert.ToString(product_dataGridView.Rows[e.RowIndex].Cells[2].Value);
				id = Convert.ToInt32(product_dataGridView.Rows[e.RowIndex].Cells[0].Value);
				
				// Populate your TextBoxes with the retrieved data (replace these with your actual TextBox names)
				productName_txtBox.Text = selectedName;
				price_txtBox.Text = selectedPrice;
			}
		}

		private void add_btn_Click(object sender, EventArgs e)
		{



			string productName = productName_txtBox.Text;
			string price = price_txtBox.Text;


			if (Validation.isEmptyStringField(new string[] {productName, price}))
			{
				return;
			} else if (!price.All(char.IsDigit))
			{
				MessageBox.Show("Price must be a Number!");
				return;
			} else if (database.CheckDataExistence($"product_name = '{productName}'", "product"))
			{
				MessageBox.Show("Product Already Exist!");
				return;
			}



			if (database.CheckDataExistence($"product_name = '{productName}' AND price = {price}", "product"))
			{
				MessageBox.Show("Data Already Exist!");
			}
			else
			{
				database.InsertData("product_name, price", $"'{productName}', {price}",  "product");
			}

			database.ReadData("SELECT * FROM product", product_dataGridView);

		}

		private void edit_btn_Click(object sender, EventArgs e)
		{
			string productName = productName_txtBox.Text;
			string price = price_txtBox.Text;

			if (!price.All(char.IsDigit))
			{
				MessageBox.Show("Price Must be a Number!");
				return;
			}

			database.UpdateData($"product_name = '{productName}', price = {price}", $" product_id = {id}", "product");

			database.ReadData("SELECT * FROM product", product_dataGridView);
		}
	}
}
