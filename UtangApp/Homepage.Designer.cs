namespace UtangApp
{
	partial class Homepage
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
			this.label1 = new System.Windows.Forms.Label();
			this.person_dataGridView = new System.Windows.Forms.DataGridView();
			this.person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.utang_dbDataSet = new UtangApp.Utang_dbDataSet();
			this.addPerson_btn = new System.Windows.Forms.Button();
			this.view_btn = new System.Windows.Forms.Button();
			this.addViewProduct_btn = new System.Windows.Forms.Button();
			this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personTableAdapter = new UtangApp.Utang_dbDataSetTableAdapters.personTableAdapter();
			this.delete_btn = new System.Windows.Forms.Button();
			this.edit_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.person_dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.utang_dbDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(198, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Utang App";
			// 
			// person_dataGridView
			// 
			this.person_dataGridView.AllowUserToAddRows = false;
			this.person_dataGridView.AllowUserToResizeColumns = false;
			this.person_dataGridView.AllowUserToResizeRows = false;
			this.person_dataGridView.AutoGenerateColumns = false;
			this.person_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.person_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.person_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.person_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.person_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.person_id,
            this.personnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.person_dataGridView.DataSource = this.personBindingSource1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.person_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.person_dataGridView.Location = new System.Drawing.Point(111, 80);
			this.person_dataGridView.Name = "person_dataGridView";
			this.person_dataGridView.ReadOnly = true;
			this.person_dataGridView.RowHeadersVisible = false;
			this.person_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.person_dataGridView.Size = new System.Drawing.Size(354, 200);
			this.person_dataGridView.TabIndex = 0;
			this.person_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.person_dataGridView_CellClick);
			// 
			// person_id
			// 
			this.person_id.DataPropertyName = "person_id";
			this.person_id.HeaderText = "person_id";
			this.person_id.Name = "person_id";
			this.person_id.ReadOnly = true;
			// 
			// personnameDataGridViewTextBoxColumn
			// 
			this.personnameDataGridViewTextBoxColumn.DataPropertyName = "person_name";
			this.personnameDataGridViewTextBoxColumn.HeaderText = "person_name";
			this.personnameDataGridViewTextBoxColumn.Name = "personnameDataGridViewTextBoxColumn";
			this.personnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// personBindingSource1
			// 
			this.personBindingSource1.DataMember = "person";
			this.personBindingSource1.DataSource = this.utang_dbDataSet;
			// 
			// utang_dbDataSet
			// 
			this.utang_dbDataSet.DataSetName = "Utang_dbDataSet";
			this.utang_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// addPerson_btn
			// 
			this.addPerson_btn.BackColor = System.Drawing.Color.MidnightBlue;
			this.addPerson_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addPerson_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addPerson_btn.ForeColor = System.Drawing.Color.White;
			this.addPerson_btn.Location = new System.Drawing.Point(158, 308);
			this.addPerson_btn.Name = "addPerson_btn";
			this.addPerson_btn.Size = new System.Drawing.Size(108, 32);
			this.addPerson_btn.TabIndex = 1;
			this.addPerson_btn.Text = "Add Person";
			this.addPerson_btn.UseVisualStyleBackColor = false;
			this.addPerson_btn.Click += new System.EventHandler(this.addPerson_btn_Click);
			// 
			// view_btn
			// 
			this.view_btn.BackColor = System.Drawing.Color.Green;
			this.view_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.view_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.view_btn.ForeColor = System.Drawing.Color.White;
			this.view_btn.Location = new System.Drawing.Point(290, 308);
			this.view_btn.Name = "view_btn";
			this.view_btn.Size = new System.Drawing.Size(108, 32);
			this.view_btn.TabIndex = 2;
			this.view_btn.Text = "View";
			this.view_btn.UseVisualStyleBackColor = false;
			this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
			// 
			// addViewProduct_btn
			// 
			this.addViewProduct_btn.BackColor = System.Drawing.Color.Silver;
			this.addViewProduct_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addViewProduct_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addViewProduct_btn.Location = new System.Drawing.Point(198, 348);
			this.addViewProduct_btn.Name = "addViewProduct_btn";
			this.addViewProduct_btn.Size = new System.Drawing.Size(161, 32);
			this.addViewProduct_btn.TabIndex = 3;
			this.addViewProduct_btn.Text = "Add View Product";
			this.addViewProduct_btn.UseVisualStyleBackColor = false;
			this.addViewProduct_btn.Click += new System.EventHandler(this.addViewProduct_btn_Click);
			// 
			// personBindingSource
			// 
			this.personBindingSource.DataMember = "person";
			this.personBindingSource.DataSource = this.utang_dbDataSet;
			// 
			// personTableAdapter
			// 
			this.personTableAdapter.ClearBeforeFill = true;
			// 
			// delete_btn
			// 
			this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.delete_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete_btn.ForeColor = System.Drawing.Color.White;
			this.delete_btn.Location = new System.Drawing.Point(290, 386);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(108, 32);
			this.delete_btn.TabIndex = 4;
			this.delete_btn.Text = "Delete";
			this.delete_btn.UseVisualStyleBackColor = false;
			this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
			// 
			// edit_btn
			// 
			this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.edit_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edit_btn.ForeColor = System.Drawing.Color.White;
			this.edit_btn.Location = new System.Drawing.Point(158, 386);
			this.edit_btn.Name = "edit_btn";
			this.edit_btn.Size = new System.Drawing.Size(108, 32);
			this.edit_btn.TabIndex = 4;
			this.edit_btn.Text = "Edit";
			this.edit_btn.UseVisualStyleBackColor = false;
			this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
			// 
			// Homepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 436);
			this.Controls.Add(this.edit_btn);
			this.Controls.Add(this.delete_btn);
			this.Controls.Add(this.addViewProduct_btn);
			this.Controls.Add(this.view_btn);
			this.Controls.Add(this.addPerson_btn);
			this.Controls.Add(this.person_dataGridView);
			this.Controls.Add(this.label1);
			this.Name = "Homepage";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homepage_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.person_dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.utang_dbDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView person_dataGridView;
		private System.Windows.Forms.Button addPerson_btn;
		private System.Windows.Forms.Button view_btn;
		private System.Windows.Forms.Button addViewProduct_btn;
		private Utang_dbDataSet utang_dbDataSet;
		private System.Windows.Forms.BindingSource personBindingSource;
		private Utang_dbDataSetTableAdapters.personTableAdapter personTableAdapter;
		private System.Windows.Forms.BindingSource personBindingSource1;
		private System.Windows.Forms.Button delete_btn;
		private System.Windows.Forms.DataGridViewTextBoxColumn person_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn personnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button edit_btn;
	}
}

