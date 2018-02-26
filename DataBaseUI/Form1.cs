using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DataBaseUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.employeesTableAdapter.Fill(this.appData.Employees);
			employeesBindingSource.DataSource = this.appData.Employees;
		}

		private void bt_New_Click(object sender, EventArgs e)
		{
			try
			{
				dataGridView1.Enabled = true;
				txt_Username.Focus();
				this.appData.Employees.AddEmployeesRow(this.appData.Employees.NewEmployeesRow());
				employeesBindingSource.MoveLast();
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				employeesBindingSource.ResetBindings(false);
			}
		}

		private void bt_Save_Click(object sender, EventArgs e)
		{
			try
			{
				employeesBindingSource.EndEdit();
				employeesTableAdapter.Update(this.appData.Employees);
				dataGridView1.Enabled = false;
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				employeesBindingSource.ResetBindings(false);
			}
		}

		private void bt_Edit_Click(object sender, EventArgs e)
		{
			dataGridView1.Enabled = true;
			txt_Username.Focus();
		}

		private void bt_Cancel_Click(object sender, EventArgs e)
		{
			dataGridView1.Enabled = false;
			employeesBindingSource.ResetBindings(false);
		}

		private void bt_Browse_Click(object sender, EventArgs e)
		{
			try
			{
				using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG | *.jpg", ValidateNames = true, Multiselect = false })
				{
					if(ofd.ShowDialog() == DialogResult.OK)
						pictureBox1.Image = Image.FromFile(ofd.FileName);
				}
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				employeesBindingSource.ResetBindings(false);
			}
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				if(MessageBox.Show("Delete this File ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					employeesBindingSource.RemoveCurrent();
			}
		}

		private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				if(string.IsNullOrEmpty(txt_Search.Text))
				{
					dataGridView1.DataSource = employeesBindingSource;
					//this.employeesTableAdapter.Fill(this.appData.Employees);
					//employeesBindingSource.DataSource = this.appData.Employees;
				} else
				{
					try
					{
						var query = from o in this.appData.Employees
												where o.FullName.Contains(txt_Search.Text) || o.PhoneNumber == txt_Search.Text
												|| o.Email == txt_Search.Text || o.Address.Contains(txt_Search.Text)
												select o;
						dataGridView1.DataSource = query.ToList();
					} catch { } 
					//employeesBindingSource.DataSource = query.ToList();		
				}
			}
		}


	}
}
