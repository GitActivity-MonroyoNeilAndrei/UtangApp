namespace UtangApp
{
	partial class AddUtangPage
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
			this.product_comboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.quantity_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.addPerson_btn = new System.Windows.Forms.Button();
			this.back_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// product_comboBox
			// 
			this.product_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.product_comboBox.FormattingEnabled = true;
			this.product_comboBox.Location = new System.Drawing.Point(223, 119);
			this.product_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.product_comboBox.Name = "product_comboBox";
			this.product_comboBox.Size = new System.Drawing.Size(229, 28);
			this.product_comboBox.TabIndex = 0;
			this.product_comboBox.SelectedIndexChanged += new System.EventHandler(this.product_comboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(249, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "Add Utang";
			// 
			// quantity_numericUpDown
			// 
			this.quantity_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quantity_numericUpDown.Location = new System.Drawing.Point(223, 180);
			this.quantity_numericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.quantity_numericUpDown.Name = "quantity_numericUpDown";
			this.quantity_numericUpDown.Size = new System.Drawing.Size(229, 31);
			this.quantity_numericUpDown.TabIndex = 2;
			this.quantity_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(226, 154);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Quantity:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(226, 90);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Product:";
			// 
			// date_dateTimePicker
			// 
			this.date_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_dateTimePicker.Location = new System.Drawing.Point(223, 246);
			this.date_dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.date_dateTimePicker.Name = "date_dateTimePicker";
			this.date_dateTimePicker.Size = new System.Drawing.Size(229, 29);
			this.date_dateTimePicker.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(226, 218);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Date:";
			// 
			// addPerson_btn
			// 
			this.addPerson_btn.BackColor = System.Drawing.Color.MidnightBlue;
			this.addPerson_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addPerson_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addPerson_btn.ForeColor = System.Drawing.Color.White;
			this.addPerson_btn.Location = new System.Drawing.Point(270, 301);
			this.addPerson_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.addPerson_btn.Name = "addPerson_btn";
			this.addPerson_btn.Size = new System.Drawing.Size(126, 32);
			this.addPerson_btn.TabIndex = 10;
			this.addPerson_btn.Text = "Add Utang";
			this.addPerson_btn.UseVisualStyleBackColor = false;
			this.addPerson_btn.Click += new System.EventHandler(this.addPerson_btn_Click);
			// 
			// back_btn
			// 
			this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.back_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back_btn.ForeColor = System.Drawing.Color.White;
			this.back_btn.Location = new System.Drawing.Point(551, 25);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(108, 32);
			this.back_btn.TabIndex = 11;
			this.back_btn.Text = "Back";
			this.back_btn.UseVisualStyleBackColor = false;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// AddUtangPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 436);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.addPerson_btn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.date_dateTimePicker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.quantity_numericUpDown);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.product_comboBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "AddUtangPage";
			this.Text = "AddUtangPage";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUtangPage_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox product_comboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown quantity_numericUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker date_dateTimePicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button addPerson_btn;
		private System.Windows.Forms.Button back_btn;
	}
}