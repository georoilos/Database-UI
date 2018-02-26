namespace DataBaseUI
{
	partial class Form1
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
			if(disposing && (components != null))
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_Address = new System.Windows.Forms.TextBox();
			this.appData = new DataBaseUI.AppData();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.txt_Phone = new System.Windows.Forms.TextBox();
			this.txt_Username = new System.Windows.Forms.TextBox();
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.bt_Browse = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.eployeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.bt_New = new System.Windows.Forms.Button();
			this.bt_Cancel = new System.Windows.Forms.Button();
			this.bt_Save = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Search = new System.Windows.Forms.TextBox();
			this.employeesTableAdapter = new DataBaseUI.AppDataTableAdapters.EmployeesTableAdapter();
			this.bt_Edit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_Address);
			this.groupBox1.Controls.Add(this.txt_Email);
			this.groupBox1.Controls.Add(this.txt_Phone);
			this.groupBox1.Controls.Add(this.txt_Username);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.bt_Browse);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(670, 381);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txt_Address
			// 
			this.txt_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appData, "Employees.Address", true));
			this.txt_Address.Location = new System.Drawing.Point(386, 269);
			this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
			this.txt_Address.Name = "txt_Address";
			this.txt_Address.Size = new System.Drawing.Size(256, 27);
			this.txt_Address.TabIndex = 5;
			// 
			// appData
			// 
			this.appData.DataSetName = "AppData";
			this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txt_Email
			// 
			this.txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appData, "Employees.Email", true));
			this.txt_Email.Location = new System.Drawing.Point(386, 194);
			this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(256, 27);
			this.txt_Email.TabIndex = 4;
			// 
			// txt_Phone
			// 
			this.txt_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appData, "Employees.PhoneNumber", true));
			this.txt_Phone.Location = new System.Drawing.Point(386, 125);
			this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
			this.txt_Phone.Name = "txt_Phone";
			this.txt_Phone.Size = new System.Drawing.Size(256, 27);
			this.txt_Phone.TabIndex = 3;
			// 
			// txt_Username
			// 
			this.txt_Username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FullName", true));
			this.txt_Username.Location = new System.Drawing.Point(386, 56);
			this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
			this.txt_Username.Name = "txt_Username";
			this.txt_Username.Size = new System.Drawing.Size(256, 27);
			this.txt_Username.TabIndex = 2;
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataMember = "Employees";
			this.employeesBindingSource.DataSource = this.appData;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(282, 275);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Address";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(304, 200);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(304, 131);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Phone";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(274, 56);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username";
			// 
			// bt_Browse
			// 
			this.bt_Browse.Location = new System.Drawing.Point(49, 298);
			this.bt_Browse.Margin = new System.Windows.Forms.Padding(4);
			this.bt_Browse.Name = "bt_Browse";
			this.bt_Browse.Size = new System.Drawing.Size(138, 41);
			this.bt_Browse.TabIndex = 1;
			this.bt_Browse.Text = "BROWSE";
			this.bt_Browse.UseVisualStyleBackColor = true;
			this.bt_Browse.Click += new System.EventHandler(this.bt_Browse_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "Image", true));
			this.pictureBox1.Location = new System.Drawing.Point(8, 43);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(240, 234);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eployeeIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
			this.dataGridView1.DataSource = this.employeesBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(702, 13);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(648, 420);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// eployeeIDDataGridViewTextBoxColumn
			// 
			this.eployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EployeeID";
			this.eployeeIDDataGridViewTextBoxColumn.HeaderText = "EployeeID";
			this.eployeeIDDataGridViewTextBoxColumn.Name = "eployeeIDDataGridViewTextBoxColumn";
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// imageDataGridViewImageColumn
			// 
			this.imageDataGridViewImageColumn.DataPropertyName = "Image";
			this.imageDataGridViewImageColumn.HeaderText = "Image";
			this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
			// 
			// bt_New
			// 
			this.bt_New.BackColor = System.Drawing.Color.Yellow;
			this.bt_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_New.ForeColor = System.Drawing.SystemColors.MenuText;
			this.bt_New.Location = new System.Drawing.Point(756, 465);
			this.bt_New.Name = "bt_New";
			this.bt_New.Size = new System.Drawing.Size(99, 38);
			this.bt_New.TabIndex = 7;
			this.bt_New.Text = "New";
			this.bt_New.UseVisualStyleBackColor = false;
			this.bt_New.Click += new System.EventHandler(this.bt_New_Click);
			// 
			// bt_Cancel
			// 
			this.bt_Cancel.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Cancel.ForeColor = System.Drawing.SystemColors.MenuText;
			this.bt_Cancel.Location = new System.Drawing.Point(1064, 465);
			this.bt_Cancel.Name = "bt_Cancel";
			this.bt_Cancel.Size = new System.Drawing.Size(99, 38);
			this.bt_Cancel.TabIndex = 9;
			this.bt_Cancel.Text = "Cancel";
			this.bt_Cancel.UseVisualStyleBackColor = false;
			this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
			// 
			// bt_Save
			// 
			this.bt_Save.BackColor = System.Drawing.Color.DarkOrange;
			this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Save.ForeColor = System.Drawing.SystemColors.MenuText;
			this.bt_Save.Location = new System.Drawing.Point(1230, 465);
			this.bt_Save.Name = "bt_Save";
			this.bt_Save.Size = new System.Drawing.Size(99, 38);
			this.bt_Save.TabIndex = 10;
			this.bt_Save.Text = "Save";
			this.bt_Save.UseVisualStyleBackColor = false;
			this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(89, 430);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Search :";
			// 
			// txt_Search
			// 
			this.txt_Search.Location = new System.Drawing.Point(189, 427);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.Size = new System.Drawing.Size(477, 27);
			this.txt_Search.TabIndex = 6;
			this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
			// 
			// bt_Edit
			// 
			this.bt_Edit.Location = new System.Drawing.Point(912, 465);
			this.bt_Edit.Name = "bt_Edit";
			this.bt_Edit.Size = new System.Drawing.Size(106, 38);
			this.bt_Edit.TabIndex = 11;
			this.bt_Edit.Text = "Edit";
			this.bt_Edit.UseVisualStyleBackColor = true;
			this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1397, 529);
			this.Controls.Add(this.bt_Edit);
			this.Controls.Add(this.txt_Search);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bt_Save);
			this.Controls.Add(this.bt_Cancel);
			this.Controls.Add(this.bt_New);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "CRUD Database";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_Address;
		private System.Windows.Forms.TextBox txt_Email;
		private System.Windows.Forms.TextBox txt_Phone;
		private System.Windows.Forms.TextBox txt_Username;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bt_Browse;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button bt_New;
		private System.Windows.Forms.Button bt_Cancel;
		private System.Windows.Forms.Button bt_Save;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_Search;
		private AppData appData;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private AppDataTableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private System.Windows.Forms.Button bt_Edit;
		private System.Windows.Forms.DataGridViewTextBoxColumn eployeeIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
	}
}

