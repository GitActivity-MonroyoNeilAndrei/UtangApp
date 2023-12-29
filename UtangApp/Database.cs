using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace UtangApp
{
	internal class Database
	{

		private string connectionString;

		public Database()
		{
			connectionString = "Data Source=DESKTOP-25623UD\\SQLEXPRESS;Initial Catalog=Utang_db;Integrated Security=True";
		}

		public void addTotalPrice()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string sql = "UPDATE utang SET total_price = utang.quantity * product.price FROM utang JOIN product ON utang.product_id = product.product_id;";

				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.ExecuteNonQuery();
				}
			}
		}


		public void ReadData(string query, DataGridView dataGridView)
		{
			using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
			{
				// Create a DataTable to hold the data
				DataTable dataTable = new DataTable();

				// Fill the DataTable with data from the database
				adapter.Fill(dataTable);

				// Bind the DataTable to the DataGridView
				dataGridView.DataSource = dataTable;
				dataGridView.Columns[0].Visible = false;
			}
		}

		public void InsertData(string column, string value, string table)
		{


			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();


				string sql = $"INSERT INTO {table} ({column}) VALUES ({value});";

				using (SqlCommand command = new SqlCommand(sql, connection))
				{

					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						// MessageBox.Show("Data inserted successfully!");
					}
					else
					{
						MessageBox.Show("Value not inserted. Check your database and try again.");
					}
				}
			}


		}

		public void DeleteData(string column, int id, string table)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure, you want to delete this data?", "", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						connection.Open();

						// Assuming you have a table named 'YourTableName' with a primary key column 'Id'
						string sql = $"DELETE FROM {table} WHERE {column} = @RecordId";

						using (SqlCommand command = new SqlCommand(sql, connection))
						{
							command.Parameters.AddWithValue("@RecordId", id);

							int rowsAffected = command.ExecuteNonQuery();

							if (rowsAffected <= 0)
							{
								MessageBox.Show("Record not found. Check your database and try again.");
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred: {ex.Message}");
				}
			}

		}

		public bool CheckDataExistence(string where, string table)
		{
			try
			{

				// Create a SQL query to check existence
				string query = $"SELECT COUNT(*) FROM {table} WHERE {where}";

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					using (SqlCommand command = new SqlCommand(query, connection))
					{

						// Execute the query
						int count = Convert.ToInt32(command.ExecuteScalar());

						if (count > 0)
						{
							return true;
						}
					}
				}
			}
			catch (Exception ex)
			{

			}
			return false;
		}

		public void UpdateData(string set, string where, string table)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();


				string sql = $"UPDATE {table} SET {set} WHERE {where};";

				using (SqlCommand command = new SqlCommand(sql, connection))
				{

					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						// MessageBox.Show("Update data successfully!");
					}
					else
					{
						MessageBox.Show("Data not inserted. Check your database and try again.");
					}
				}
			}
		}

		public string GetData (string column, string idColumn, int id, string table)
		{

			try
			{
				// Define your SQL query to retrieve a specific cell value
				string query = $"SELECT {column} FROM {table} WHERE {idColumn} = {id};";

				// Open a connection to the database
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					// Execute the query
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// ExecuteScalar is used to retrieve a single value from the database
						object result = command.ExecuteScalar();

						// Check if the result is not null before using it
						if (result != null)
						{
							// Convert the result to the appropriate data type (e.g., string, int, etc.)
							string cellValue = result.ToString();

							// Display the retrieved cell value in the label
							return cellValue;
						}
						else
						{
							return "No data";
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				return "eror occured";
			}
		}


		public string AdvanceGetData(string query)
		{
			try
			{

				// Open a connection to the database
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					// Execute the query
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// ExecuteScalar is used to retrieve a single value from the database
						object result = command.ExecuteScalar();

						// Check if the result is not null before using it
						if (result != null)
						{
							// Convert the result to the appropriate data type (e.g., string, int, etc.)
							string cellValue = result.ToString();

							// Display the retrieved cell value in the label
							return cellValue;
						}
						else
						{
							return "No data";
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				return "eror occured";
			}
		}


	}
}
