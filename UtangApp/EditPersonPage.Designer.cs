namespace UtangApp
{
	partial class EditPersonPage
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
			this.address_txtBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.name_txtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.back_btn = new System.Windows.Forms.Button();
			this.saveChanges_btn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// address_txtBox
			// 
			this.address_txtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.address_txtBox.Location = new System.Drawing.Point(200, 259);
			this.address_txtBox.Name = "address_txtBox";
			this.address_txtBox.Size = new System.Drawing.Size(182, 27);
			this.address_txtBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(204, 236);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Address:";
			// 
			// name_txtBox
			// 
			this.name_txtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_txtBox.Location = new System.Drawing.Point(200, 187);
			this.name_txtBox.Name = "name_txtBox";
			this.name_txtBox.Size = new System.Drawing.Size(182, 27);
			this.name_txtBox.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(204, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Person\'s Name:";
			// 
			// back_btn
			// 
			this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.back_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back_btn.ForeColor = System.Drawing.Color.White;
			this.back_btn.Location = new System.Drawing.Point(451, 58);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(108, 32);
			this.back_btn.TabIndex = 10;
			this.back_btn.Text = "Back";
			this.back_btn.UseVisualStyleBackColor = false;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// saveChanges_btn
			// 
			this.saveChanges_btn.BackColor = System.Drawing.Color.MidnightBlue;
			this.saveChanges_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.saveChanges_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveChanges_btn.ForeColor = System.Drawing.Color.White;
			this.saveChanges_btn.Location = new System.Drawing.Point(226, 349);
			this.saveChanges_btn.Name = "saveChanges_btn";
			this.saveChanges_btn.Size = new System.Drawing.Size(125, 32);
			this.saveChanges_btn.TabIndex = 9;
			this.saveChanges_btn.Text = "Save Changes";
			this.saveChanges_btn.UseVisualStyleBackColor = false;
			this.saveChanges_btn.Click += new System.EventHandler(this.saveChanges_btn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(199, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 35);
			this.label1.TabIndex = 8;
			this.label1.Text = "Edit Person";
			// 
			// EditPersonPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 436);
			this.Controls.Add(this.address_txtBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.name_txtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.saveChanges_btn);
			this.Controls.Add(this.label1);
			this.Name = "EditPersonPage";
			this.Text = "EditPersonPage";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPersonPage_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox address_txtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox name_txtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button back_btn;
		private System.Windows.Forms.Button saveChanges_btn;
		private System.Windows.Forms.Label label1;
	}
}