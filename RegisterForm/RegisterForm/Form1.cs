using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterForm
{
    public partial class Form1 : Form
    {
        List<Employee> Employers = new List<Employee>();
        List<Employee> DeletedUsers = new List<Employee>();
        ExtraMethods extraMethods = new ExtraMethods();
        public Form1()
        {
            InitializeComponent();
        }

        int empID = 0;
        int rowId = 0; // id of selected row
        bool update = false;

        // Saving inputs to array
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!update)
            {
                if (InputsIsValid())
                {
                    Employee employee = new Employee();
                    employee.ID = empID++;
                    employee.Name = txtName.Text;
                    employee.Surname = txtSurname.Text;
                    employee.Email = txtEmail.Text;
                    employee.Position = txtPosition.Text;
                    employee.Salary = Convert.ToDouble(txtSalary.Text.Replace(".", ",")); 

                    Employers.Add(employee);
                    RefreshGrid();
                    ClearInputs();
                }
            }
            else
            {
                for (int i = 0; i < Employers.Count; i++)
                {
                    if (Employers[i].ID == Convert.ToUInt32(updateID.Text))
                    {

                        if (InputsIsValid())
                        {
                            Employers[i].Name = txtName.Text;
                            Employers[i].Surname = txtSurname.Text;
                            Employers[i].Email = txtEmail.Text;
                            Employers[i].Position = txtPosition.Text;
                            Employers[i].Salary = Convert.ToDouble(txtSalary.Text.Replace(".", ","));

                            RefreshGrid();
                            ClearInputs();
                            BtnSave.Text = "Siyahıya yaz";
                            update = false;
                            break;
                        }
                    }
                }
            }
        }

        // Selecting rows
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            rowId = Convert.ToInt32(e.Row.Cells[0].Value);
        }

        // Double click to row
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                updateID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // hidden label
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPosition.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                BtnSave.Text = "Yenilə";
                update = true;
            }
            catch(Exception) { }
            
        }

        // Deleting rows
        private void DeleteRow(object sender, EventArgs e)
        {
            try
            {

                Employee emp = Employers.Single(elm => elm.ID == rowId);
                DeletedUsers.Add(emp); // adding to deleted users
                Employers.Remove(emp); // remove from employers
            }
            catch (Exception exp) { MessageBox.Show(exp.ToString()); }
            RefreshGrid();
        }

        // Input validate
        public bool InputsIsValid()
        {
            int valid = 0;
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox)
                {
                    if (extraMethods.CheckInput(control.AccessibleName, control.Text, control.AccessibleDescription) == "ok")
                    {
                        valid++;
                        changeDesign(control,"normal");
                    }
                    else
                    {
                        changeDesign(control,"red");

                        ToolTip toolTip = new ToolTip();
                        toolTip.IsBalloon = true;
                        toolTip.Show(extraMethods.CheckInput(control.AccessibleName, control.Text, control.AccessibleDescription), control, 120, -50, 2000);
                    }
                }
            }

            if (valid == 5) return true;
            else return false;
        }

        // Clear inputs
        public void ClearInputs()
        {
            foreach (Control con in panel1.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
            }
        }

        // Writing List to grid
        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Employers.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = Employers[i].ID;
                row.Cells[1].Value = Employers[i].Name;
                row.Cells[2].Value = Employers[i].Surname;
                row.Cells[3].Value = Employers[i].Email;
                row.Cells[4].Value = Employers[i].Position;
                row.Cells[5].Value = Employers[i].Salary;
                dataGridView1.Rows.Add(row);
            }
        }

        // change design on validation
        public void changeDesign(Control control, string type)
        {
            foreach (Control con in panel1.Controls)
            {
                if (con is Panel && con.AccessibleName == control.AccessibleName)
                {
                    if(type == "red")
                    {
                        con.BackColor = Color.FromArgb(238, 146, 143);
                    }
                    else
                    {
                        con.BackColor = Color.Cyan;
                        
                    }
                    
                }
                if (con is PictureBox && con.AccessibleName == control.AccessibleName)
                {
                    if (type == "red")
                    {
                        con.Hide();
                    }
                    else
                    {
                        con.Show();
                    }
                }
            }
        }

        // checking every input on type
        public void CheckOnType(TextBox textbox)
        {
            if (textbox.Text != string.Empty)
            {
                if (extraMethods.CheckInput(textbox.AccessibleName, textbox.Text, textbox.AccessibleDescription.ToString()) != "ok")
                {
                    changeDesign(textbox, "red");
                }
                else { changeDesign(textbox, "normal"); }
            }
        }

        //  ON TYPE METHODS OF INPUTS
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CheckOnType(txtSurname);
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            CheckOnType(txtSalary);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckOnType(txtEmail);
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            CheckOnType(txtPosition);
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            CheckOnType(txtName);
        }

        // Open second Form
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(DeletedUsers);
            this.Opacity = 0.7;
            frm2.ShowDialog();
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
             var result = MessageBox.Show("Məlumatlar silinəcək, çıxmaq istədiyinizə əminsiz ?", "", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
