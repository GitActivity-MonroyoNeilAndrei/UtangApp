namespace UtangApp
{
	partial class PersonPage
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.back_btn = new System.Windows.Forms.Button();
			this.utangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.utang_dbDataSet = new UtangApp.Utang_dbDataSet();
			this.name_label = new System.Windows.Forms.Label();
			this.paid_btn = new System.Windows.Forms.Button();
			this.makePaid_btn = new System.Windows.Forms.Button();
			this.add_btn = new System.Windows.Forms.Button();
			this.edit_btn = new System.Windows.Forms.Button();
			this.unpaid_btn = new System.Windows.Forms.Button();
			this.utangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.utangTableAdapter = new UtangApp.Utang_dbDataSetTableAdapters.utangTableAdapter();
			this.utangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.utangBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.utang_dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.utangBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.utang_dbDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.utangBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.utangBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.utangBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.utang_dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// back_btn
			// 
			this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.back_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back_btn.ForeColor = System.Drawing.Color.White;
			this.back_btn.Location = new System.Drawing.Point(475, 33);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(108, 32);
			this.back_btn.TabIndex = 7;
			this.back_btn.Text = "Back";
			this.back_btn.UseVisualStyleBackColor = false;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// utangBindingSource1
			// 
			this.utangBindingSource1.DataMember = "utang";
			this.utangBindingSource1.DataSource = this.utang_dbDataSet;
			// 
			// utang_dbDataSet
			// 
			this.utang_dbDataSet.DataSetName = "Utang_dbDataSet";
			this.utang_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// name_label
			// 
			this.name_label.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_label.Location = new System.Drawing.Point(111, 30);
			this.name_label.Name = "name_label";
			this.name_label.Size = new System.Drawing.Size(364, 35);
			this.name_label.TabIndex = 9;
			this.name_label.Text = "Products";
			this.name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// paid_btn
			// 
			this.paid_btn.BackColor = System.Drawing.Color.Gray;
			this.paid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.paid_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paid_btn.ForeColor = System.Drawing.Color.Black;
			this.paid_btn.Location = new System.Drawing.Point(294, 80);
			this.paid_btn.Name = "paid_btn";
			this.paid_btn.Size = new System.Drawing.Size(84, 23);
			this.paid_btn.TabIndex = 10;
			this.paid_btn.Text = "Paid";
			this.paid_btn.UseVisualStyleBackColor = false;
			this.paid_btn.Click += new System.EventHandler(this.paid_btn_Click);
			// 
			// makePaid_btn
			// 
			this.makePaid_btn.BackColor = System.Drawing.Color.Blue;
			this.makePaid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.makePaid_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.makePaid_btn.ForeColor = System.Drawing.Color.White;
			this.makePaid_btn.Location = new System.Drawing.Point(167, 350);
			this.makePaid_btn.Name = "makePaid_btn";
			this.makePaid_btn.Size = new System.Drawing.Size(108, 32);
			this.makePaid_btn.TabIndex = 10;
			this.makePaid_btn.Text = "Paid";
			this.makePaid_btn.UseVisualStyleBackColor = false;
			this.makePaid_btn.Click += new System.EventHandler(this.makePaid_btn_Click);
			// 
			// add_btn
			// 
			this.add_btn.BackColor = System.Drawing.Color.Green;
			this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.add_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_btn.ForeColor = System.Drawing.Color.White;
			this.add_btn.Location = new System.Drawing.Point(307, 350);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(108, 32);
			this.add_btn.TabIndex = 10;
			this.add_btn.Text = "Add";
			this.add_btn.UseVisualStyleBackColor = false;
			this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
			// 
			// edit_btn
			// 
			this.edit_btn.BackColor = System.Drawing.Color.Silver;
			this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.edit_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edit_btn.Location = new System.Drawing.Point(237, 392);
			this.edit_btn.Name = "edit_btn";
			this.edit_btn.Size = new System.Drawing.Size(108, 32);
			this.edit_btn.TabIndex = 10;
			this.edit_btn.Text = "Edit";
			this.edit_btn.UseVisualStyleBackColor = false;
			this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
			// 
			// unpaid_btn
			// 
			this.unpaid_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.unpaid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.unpaid_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unpaid_btn.ForeColor = System.Drawing.Color.White;
			this.unpaid_btn.Location = new System.Drawing.Point(212, 80);
			this.unpaid_btn.Name = "unpaid_btn";
			this.unpaid_btn.Size = new System.Drawing.Size(84, 23);
			this.unpaid_btn.TabIndex = 10;
			this.unpaid_btn.Text = "Unpaid";
			this.unpaid_btn.UseVisualStyleBackColor = false;
			this.unpaid_btn.Click += new System.EventHandler(this.unpaid_btn_Click);
			// 
			// utangBindingSource
			// 
			this.utangBindingSource.DataMember = "utang";
			this.utangBindingSource.DataSource = this.utang_dbDataSet;
			// 
			// utangTableAdapter
			// 
			this.utangTableAdapter.ClearBeforeFill = true;
			// 
			// utangBindingSource2
			// 
			this.utangBindingSource2.DataMember = "utang";
			this.utangBindingSource2.DataSource = this.utang_dbDataSet;
			// 
			// utangBindingSource3
			// 
			this.utangBindingSource3.DataMember = "utang";
			this.utangBindingSource3.DataSource = this.utang_dbDataSet;
			// 
			// utang_dataGridView
			// 
			this.utang_dataGridView.AllowUserToAddRows = false;
			this.utang_dataGridView.AllowUserToResizeColumns = false;
			this.utang_dataGridView.AllowUserToResizeRows = false;
			this.utang_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.utang_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.utang_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.utang_dataGridView.Location = new System.Drawing.Point(12, 109);
			this.utang_dataGridView.Name = "utang_dataGridView";
			this.utang_dataGridView.ReadOnly = true;
			this.utang_dataGridView.RowHeadersVisible = false;
			this.utang_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.utang_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.utang_dataGridView.Size = new System.Drawing.Size(564, 215);
			this.utang_dataGridView.TabIndex = 11;
			this.utang_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.utang_dataGridView_CellClick);
			// 
			// PersonPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 436);
			this.Controls.Add(this.utang_dataGridView);
			this.Controls.Add(this.edit_btn);
			this.Controls.Add(this.add_btn);
			this.Controls.Add(this.makePaid_btn);
			this.Controls.Add(this.unpaid_btn);
			this.Controls.Add(this.paid_btn);
			this.Controls.Add(this.name_label);
			this.Controls.Add(this.back_btn);
			this.Name = "PersonPage";
			this.Text = "PersonPage";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonPage_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.utangBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.utang_dbDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.utangBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.utangBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.utangBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.utang_dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button back_btn;
		private System.Windows.Forms.Label name_label;
		private System.Windows.Forms.Button paid_btn;
		private System.Windows.Forms.Button makePaid_btn;
		private System.Windows.Forms.Button add_btn;
		private System.Windows.Forms.Button edit_btn;
		private System.Windows.Forms.Button unpaid_btn;
		private Utang_dbDataSet utang_dbDataSet;
		private System.Windows.Forms.BindingSource utangBindingSource;
		private Utang_dbDataSetTableAdapters.utangTableAdapter utangTableAdapter;
		private System.Windows.Forms.BindingSource utangBindingSource1;
		private System.Windows.Forms.BindingSource utangBindingSource2;
		private System.Windows.Forms.BindingSource utangBindingSource3;
		private System.Windows.Forms.DataGridView utang_dataGridView;
	}
}