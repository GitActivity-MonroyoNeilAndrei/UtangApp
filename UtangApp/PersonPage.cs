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
	public partial class PersonPage : Form
	{
		Database database = new Database();
		private int utang_id;
		private int person_id;

		private string paid = "unpaid";



		public PersonPage(int id)
		{
			InitializeComponent();

			this.person_id = id;

			name_label.Text =  database.GetData("person_name", "person_id", person_id, "person");
			database.ReadData($"SELECT utang.utang_id, product.product_name, utang.quantity, product.price, utang.total_price,  utang.date_loaned FROM utang JOIN product ON utang.product_id = product.product_id JOIN person ON utang.person_id = person.person_id WHERE person.person_id = {person_id} AND utang.status = '{paid}';", utang_dataGridView);

			if (utang_dataGridView.RowCount > 0)
			{
				utang_dataGridView.Rows[0].Selected = true;
				this.utang_id = Convert.ToInt32(utang_dataGridView.SelectedRows[0].Cells[0].Value);
			}

				

			


		}


		private void changeNavStatus ()
		{
			if (paid == "paid")
			{
				paid_btn.BackColor = Color.FromArgb(0, 0, 192);
				paid_btn.ForeColor = Color.FromArgb(255, 255, 255);

				unpaid_btn.BackColor = System.Drawing.Color.Gray;
				unpaid_btn.ForeColor = Color.FromArgb(0, 0, 0);
			}
			else if (paid == "unpaid") 
			{
				paid_btn.BackColor = System.Drawing.Color.Gray;
				paid_btn.ForeColor = Color.FromArgb(0, 0, 0);


				unpaid_btn.BackColor = Color.FromArgb(0, 0, 192);
				unpaid_btn.ForeColor = Color.FromArgb(255, 255, 255);
			}

			database.ReadData($"SELECT utang.utang_id, product.product_name, utang.quantity, product.price, utang.total_price,  utang.date_loaned FROM utang JOIN product ON utang.product_id = product.product_id JOIN person ON utang.person_id = person.person_id WHERE person.person_id = {person_id} AND utang.status = '{paid}';", utang_dataGridView);
		}

		private void back_btn_Click(object sender, EventArgs e)
		{
			Homepage homepage = new Homepage();
			homepage.Show();
			homepage.Location = this.Location;

			this.Hide();
		}

		private void PersonPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void unpaid_btn_Click(object sender, EventArgs e)
		{
			paid = "unpaid";
			changeNavStatus();

		}

		private void paid_btn_Click(object sender, EventArgs e)
		{
			paid = "paid";
			changeNavStatus();
		}

		private void makePaid_btn_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure, you want to change the status?", "", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				database.UpdateData("status = 'paid'", $"utang_id = {utang_id}", "utang");

				database.ReadData($"SELECT utang.utang_id, product.product_name, utang.quantity, product.price, utang.total_price, utang.date_loaned FROM utang JOIN product ON utang.product_id = product.product_id JOIN person ON utang.person_id = person.person_id WHERE person.person_id = {person_id} AND utang.status = '{paid}';", utang_dataGridView);
			}
				
		}

		private void utang_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.utang_id = Convert.ToInt32(utang_dataGridView.SelectedRows[0].Cells[0].Value);
			Console.WriteLine(utang_id);
		}

		private void add_btn_Click(object sender, EventArgs e)
		{
			AddUtangPage addUtangPage = new AddUtangPage(person_id);
			addUtangPage.Show();
			addUtangPage.Location = this.Location;

			this.Hide();
		}

		private void edit_btn_Click(object sender, EventArgs e)
		{
			Console.WriteLine(utang_id);
			EditUtangPage editUtangPage = new EditUtangPage(person_id, utang_id);
			editUtangPage.Show();
			editUtangPage.Location = this.Location;

			this.Hide();
		}
	}
}
