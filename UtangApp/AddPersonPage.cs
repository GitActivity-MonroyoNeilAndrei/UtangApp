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
	public partial class AddPersonPage : Form
	{
		Database database = new Database();

		public AddPersonPage()
		{
			InitializeComponent();
		}

		private void AddPersonPage_Load(object sender, EventArgs e)
		{

		}

		private void addPerson_btn_Click(object sender, EventArgs e)
		{
			string name = name_txtBox.Text;
			string address = address_txtBox.Text;
			string[] arr = { name, address };

			if (Validation.isEmptyStringField(arr))
			{
				return;
			} else if (database.CheckDataExistence($" person_name = '{name}'", "person"))
			{
				MessageBox.Show("Person Already Exist!");
				return;
			} else
			{
				
				database.InsertData("person_name, address", $"'{name}', '{address}'", "person");


				name_txtBox.Text = string.Empty;
				address_txtBox.Text = string.Empty;

				MessageBox.Show("Peron Added Successfully!");
			}


			

		}

		private void AddPersonPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Homepage homepage = new Homepage();
			homepage.Show();
			homepage.Location = this.Location;

			this.Hide();
		}
	}
}
