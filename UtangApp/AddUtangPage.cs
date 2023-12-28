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
	public partial class AddUtangPage : Form
	{
		private int person_id = 0;
		private int selectedId = 0;
		Database database = new Database();

		public AddUtangPage(int id)
		{
			InitializeComponent();
			PopulateComboBox();

			this.person_id = id;
		}

		public class ComboBoxItem
		{
			public int Id { get; set; }
			public string Name { get; set; }

			public override string ToString()
			{
				return Name;
			}
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

			// Optionally, set the default selected item
			if (product_comboBox.Items.Count > 0)
			{
				product_comboBox.SelectedIndex = 0;
			}
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

			}
		}

		private void AddUtangPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void addPerson_btn_Click(object sender, EventArgs e)
		{
			database.InsertData("product_id, quantity, person_id, status, date_loaned", $"{selectedId}, {quantity_numericUpDown.Value}, {person_id}, 'unpaid', '{date_dateTimePicker.Value}' ", "utang");

			MessageBox.Show("Utang Added Successfully!");
		}

		private void back_btn_Click(object sender, EventArgs e)
		{
			PersonPage personPage = new PersonPage(person_id);
			personPage.Show();
			personPage.Location = this.Location;

			this.Hide();
		}
	}


	
}
