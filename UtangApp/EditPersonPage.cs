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
	public partial class EditPersonPage : Form
	{
		private int person_id;
		Database database = new Database();

		public EditPersonPage(int id)
		{
			InitializeComponent();

			person_id = id;

			name_txtBox.Text = database.GetData("person_name", "person_id", id, "person");
			address_txtBox.Text = database.GetData("address", "person_id", id, "person");

		}

		private void EditPersonPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void back_btn_Click(object sender, EventArgs e)
		{
			Homepage homePage = new Homepage();
			homePage.Show();
			homePage.Location = this.Location;

			this.Hide();
		}

		private void saveChanges_btn_Click(object sender, EventArgs e)
		{

			string name = name_txtBox.Text;
			string address = address_txtBox.Text;
			string[] arr = { name, address };

			if (Validation.isEmptyStringField(arr))
			{
				return;
			} else if (database.CheckDataExistence($" person_name = '{name_txtBox.Text}'", "person"))
			{
				MessageBox.Show("Person already Exist!");
				return;
			} 

			DialogResult dialogResult = MessageBox.Show("Are you sure you want to Save Changes?", "", MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.Yes)
			{
				database.UpdateData($" person_name = '{name_txtBox.Text}', address = '{address_txtBox.Text}' ", $" person_id = {person_id} ", "person");
			}
		}
	}
}
