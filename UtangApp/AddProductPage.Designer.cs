namespace UtangApp
{
	partial class AddProductPage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.product_dataGridView = new System.Windows.Forms.DataGridView();
			this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.utang_dbDataSet = new UtangApp.Utang_dbDataSet();
			this.productTableAdapter = new UtangApp.Utang_dbDataSetTableAdapters.productTableAdapter();
			this.add_btn = new System.Windows.Forms.Button();
			this.edit_btn = new System.Windows.Forms.Button();
			this.delete_btn = new System.Windows.Forms.Button();
			this.back_btn = new System.Windows.Forms.Button();
			this.productName_txtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.price_txtBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.product_dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.utang_dbDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(211, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "Products";
			// 
			// product_dataGridView
			// 
			this.product_dataGridView.AllowUserToAddRows = false;
			this.product_dataGridView.AllowUserToResizeColumns = false;
			this.product_dataGridView.AllowUserToResizeRows = false;
			this.product_dataGridView.AutoGenerateColumns = false;
			this.product_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.product_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.product_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.product_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.product_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.productnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.product_dataGridView.DataSource = this.productBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.product_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.product_dataGridView.Location = new System.Drawing.Point(115, 115);
			this.product_dataGridView.MultiSelect = false;
			this.product_dataGridView.Name = "product_dataGridView";
			this.product_dataGridView.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.product_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.product_dataGridView.RowHeadersVisible = false;
			this.product_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.product_dataGridView.Size = new System.Drawing.Size(354, 200);
			this.product_dataGridView.TabIndex = 2;
			this.product_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_dataGridView_CellDoubleClick);
			// 
			// product_id
			// 
			this.product_id.DataPropertyName = "product_id";
			this.product_id.HeaderText = "product_id";
			this.product_id.Name = "product_id";
			this.product_id.ReadOnly = true;
			// 
			// productnameDataGridViewTextBoxColumn
			// 
			this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
			this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
			this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
			this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataMember = "product";
			this.productBindingSource.DataSource = this.utang_dbDataSet;
			// 
			// utang_dbDataSet
			// 
			this.utang_dbDataSet.DataSetName = "Utang_dbDataSet";
			this.utang_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// add_btn
			// 
			this.add_btn.BackColor = System.Drawing.Color.MidnightBlue;
			this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.add_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_btn.ForeColor = System.Drawing.Color.White;
			this.add_btn.Location = new System.Drawing.Point(232, 382);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(108, 32);
			this.add_btn.TabIndex = 3;
			this.add_btn.Text = "Add";
			this.add_btn.UseVisualStyleBackColor = false;
			this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
			// 
			// edit_btn
			// 
			this.edit_btn.BackColor = System.Drawing.Color.Silver;
			this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.edit_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edit_btn.Location = new System.Drawing.Point(162, 330);
			this.edit_btn.Name = "edit_btn";
			this.edit_btn.Size = new System.Drawing.Size(108, 32);
			this.edit_btn.TabIndex = 4;
			this.edit_btn.Text = "Edit";
			this.edit_btn.UseVisualStyleBackColor = false;
			this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
			// 
			// delete_btn
			// 
			this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.delete_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete_btn.ForeColor = System.Drawing.Color.White;
			this.delete_btn.Location = new System.Drawing.Point(303, 330);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(108, 32);
			this.delete_btn.TabIndex = 5;
			this.delete_btn.Text = "Delete";
			this.delete_btn.UseVisualStyleBackColor = false;
			this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
			// 
			// back_btn
			// 
			this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.back_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back_btn.ForeColor = System.Drawing.Color.White;
			this.back_btn.Location = new System.Drawing.Point(444, 24);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(108, 32);
			this.back_btn.TabIndex = 6;
			this.back_btn.Text = "Back";
			this.back_btn.UseVisualStyleBackColor = false;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// productName_txtBox
			// 
			this.productName_txtBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productName_txtBox.Location = new System.Drawing.Point(127, 82);
			this.productName_txtBox.Name = "productName_txtBox";
			this.productName_txtBox.Size = new System.Drawing.Size(138, 23);
			this.productName_txtBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(129, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Product\'s Name:";
			// 
			// price_txtBox
			// 
			this.price_txtBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.price_txtBox.Location = new System.Drawing.Point(318, 82);
			this.price_txtBox.Name = "price_txtBox";
			this.price_txtBox.Size = new System.Drawing.Size(138, 23);
			this.price_txtBox.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(320, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 19);
			this.label3.TabIndex = 10;
			this.label3.Text = "Price:";
			// 
			// AddProductPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 436);
			this.Controls.Add(this.price_txtBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.productName_txtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.delete_btn);
			this.Controls.Add(this.edit_btn);
			this.Controls.Add(this.add_btn);
			this.Controls.Add(this.product_dataGridView);
			this.Controls.Add(this.label1);
			this.Name = "AddProductPage";
			this.Text = "AddProductPage";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductPage_FormClosing);
			this.Load += new System.EventHandler(this.AddProductPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.product_dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.utang_dbDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView product_dataGridView;
		private Utang_dbDataSet utang_dbDataSet;
		private System.Windows.Forms.BindingSource productBindingSource;
		private Utang_dbDataSetTableAdapters.productTableAdapter productTableAdapter;
		private System.Windows.Forms.Button add_btn;
		private System.Windows.Forms.Button edit_btn;
		private System.Windows.Forms.Button delete_btn;
		private System.Windows.Forms.Button back_btn;
		private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox productName_txtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox price_txtBox;
		private System.Windows.Forms.Label label3;
	}
}