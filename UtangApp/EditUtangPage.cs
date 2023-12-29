using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UtangApp
{

	public class ComboBoxItem
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}

	public partial class EditUtangPage : Form
	{
		private int selectedId = 0;
		private int person_id = 0;
		private int utang_id = 0;
		Database database = new Database();

		public EditUtangPage(int idPerson, int idUtang)
		{
			this.person_id = idPerson;
			this.utang_id = idUtang;

			InitializeComponent();

			

			PopulateComboBox();


			quantity_numericUpDown.Value = int.Parse(database.GetData("quantity", "utang_id", idUtang, "utang"));
			date_dateTimePicker.Value = DateTime.Parse(database.GetData("date_loaned", "utang_id", idUtang, "utang"));
		}




		private void PopulateComboBox()
		{
			string connectionString = "Data Source=DESKTOP-25623UD\\SQLEXPRESS;Initial Catalog=Utang_db;Integrated Security=True";
			string query = "SELECT product_id, product_name FROM product"; // Replace with your actual table and column names

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							// Assuming the first column is the ID and the second is the name
							int id = reader.GetInt32(0);
							string name = reader.GetString(1);

							// Create a ComboBoxItem and add it to the ComboBox
							ComboBoxItem item = new ComboBoxItem { Id = id, Name = name };
							product_comboBox.Items.Add(item);
						}
					}
				}
			}



			string desiredItem = database.AdvanceGetData($"SELECT product.product_name FROM utang JOIN product ON utang.product_id = product.product_id WHERE utang.utang_id = {utang_id};");

			Console.WriteLine(utang_id);


			int itemIndex = -1; // Initialize with -1 to indicate not found

			for (int i = 0; i < product_comboBox.Items.Count; i++)
			{
				if (product_comboBox.Items[i].ToString() == desiredItem)
				{
					itemIndex = i; // Set the index if the item is found
					break;
				}
			}

			product_comboBox.SelectedIndex = itemIndex;

		}

		private void product_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Check if an item is selected
			if (product_comboBox.SelectedItem != null)
			{
				// Cast the selected item to your custom class
				ComboBoxItem selectedComboItem = (ComboBoxItem)product_comboBox.SelectedItem;

				// Access the ID property
				selectedId = selectedComboItem.Id;

				Console.WriteLine(selectedId);

			}
		}



		private void back_btn_Click(object sender, EventArgs e)
		{
			PersonPage personPage = new PersonPage(person_id);
			personPage.Show();
			personPage.Location = this.Location;

			this.Hide();
		}

		private void EditUtangPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void editPerson_btn_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to Save Changes?", "", MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.Yes)
			{
				database.UpdateData($" product_id = '{selectedId}', quantity = {quantity_numericUpDown.Value}, date_loaned = '{date_dateTimePicker.Value}' ", $" utang_id = {utang_id} ", "utang");

				database.addTotalPrice();

				MessageBox.Show("Utang Edited Successfully!");
			}
		}
	}
}
