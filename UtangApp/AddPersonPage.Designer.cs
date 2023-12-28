namespace UtangApp
{
	partial class AddPersonPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.addPerson_btn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.name_txtBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.address_txtBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(198, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "Add Person";
			// 
			// addPerson_btn
			// 
			this.addPerson_btn.BackColor = System.Drawing.Color.MidnightBlue;
			this.addPerson_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addPerson_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addPerson_btn.ForeColor = System.Drawing.Color.White;
			this.addPerson_btn.Location = new System.Drawing.Point(238, 315);
			this.addPerson_btn.Name = "addPerson_btn";
			this.addPerson_btn.Size = new System.Drawing.Size(108, 32);
			this.addPerson_btn.TabIndex = 2;
			this.addPerson_btn.Text = "Add";
			this.addPerson_btn.UseVisualStyleBackColor = false;
			this.addPerson_btn.Click += new System.EventHandler(this.addPerson_btn_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(450, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(203, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Person\'s Name:";
			// 
			// name_txtBox
			// 
			this.name_txtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_txtBox.Location = new System.Drawing.Point(199, 153);
			this.name_txtBox.Name = "name_txtBox";
			this.name_txtBox.Size = new System.Drawing.Size(182, 27);
			this.name_txtBox.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(203, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Address:";
			// 
			// address_txtBox
			// 
			this.address_txtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.address_txtBox.Location = new System.Drawing.Point(199, 225);
			this.address_txtBox.Name = "address_txtBox";
			this.address_txtBox.Size = new System.Drawing.Size(182, 27);
			this.address_txtBox.TabIndex = 1;
			// 
			// AddPersonPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 436);
			this.Controls.Add(this.address_txtBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.name_txtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.addPerson_btn);
			this.Controls.Add(this.label1);
			this.Name = "AddPersonPage";
			this.Text = "AddPersonPage";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPersonPage_FormClosing);
			this.Load += new System.EventHandler(this.AddPersonPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addPerson_btn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox name_txtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox address_txtBox;
	}
}