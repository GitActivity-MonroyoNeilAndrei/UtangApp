using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtangApp
{
	public partial class Homepage : Form
	{

		private int id = 0;

		Database database = new Database();

		public Homepage()
		{
			InitializeComponent();
			
			database.ReadData("SELECT * FROM person", person_dataGridView);

			if (person_dataGridView.RowCount > 0)
			{
				person_dataGridView.Rows[0].Selected = true;

				id = Convert.ToInt32(person_dataGridView.SelectedRows[0].Cells[0].Value);
			}

			



		}



		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'utang_dbDataSet.person' table. You can move, or remove it, as needed.
			this.personTableAdapter.Fill(this.utang_dbDataSet.person);

		}

		private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void addPerson_btn_Click(object sender, EventArgs e)
		{
			AddPersonPage addPersonPage = new AddPersonPage();
			addPersonPage.Show();
			addPersonPage.Location = this.Location;

			this.Hide();
		}

		private void view_btn_Click(object sender, EventArgs e)
		{

			PersonPage personPage = new PersonPage(id);
			personPage.Show();
			personPage.Location = this.Location;

			this.Hide();
		}

		private void addViewProduct_btn_Click(object sender, EventArgs e)
		{
			AddProductPage addProductPage = new AddProductPage();
			addProductPage.Show();
			addProductPage.Location = this.Location;

			this.Hide();
		}

		private void delete_btn_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(person_dataGridView.SelectedRows[0].Cells[0].Value);


			database.DeleteData("person_id", id, "person");

			database.ReadData("SELECT * FROM person", person_dataGridView);
		}

		private void person_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = Convert.ToInt32(person_dataGridView.SelectedRows[0].Cells[0].Value);

		}

		private void edit_btn_Click(object sender, EventArgs e)
		{
			EditPersonPage editPersonPage = new EditPersonPage(id);
			editPersonPage.Show();
			editPersonPage.Location = this.Location;

			this.Hide();
		}
	}
}
