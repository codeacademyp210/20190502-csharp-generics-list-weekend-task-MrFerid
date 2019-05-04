using System;
using System.Collections;
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
        public Form1()
        {
            InitializeComponent();
        }

        List<Employee> Employers = new List<Employee>();
        ExtraMethods extraMethods = new ExtraMethods();

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
                    employee.Salary = Convert.ToDouble(txtSalary.Text.Replace(".", ",") );

                    Employers.Add(employee);
                    RefreshGrid();
                    ClearInputs();
                    BtnSave.Text = "Save";
                }
            }
            else
            {
                for(int i=0; i<Employers.Count; i++)
                {
                    if(Employers[i].ID == rowId)
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
                    rowId = Convert.ToInt32( e.Row.Cells[0].Value );
        }
        // Double click to row
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            int cellIndex = 0;
                foreach (Control control in panel1.Controls)
                {
                    if (control is TextBox)
                    {
                        cellIndex++;
                        control.Text = dataGridView1.Rows[e.RowIndex].Cells[cellIndex].Value.ToString();
                    }
                }
            BtnSave.Text = "Update";
            update = true;
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
        // Deleting rows
        private void DeleteRow(object sender, EventArgs e)
        {
            try
            {
                Employers.RemoveAll(m => m.ID == rowId);
            }
            catch (Exception exp) { MessageBox.Show(exp.ToString()); }
            RefreshGrid();
        }

        // Input validate
        public bool InputsIsValid()
        {
            txtError.Text = string.Empty;
            string errText = "";
            int valid = 0;
            foreach (Control cont in panel1.Controls)
            {
                if (cont is TextBox)
                {
                    if (extraMethods.CheckInput(cont.AccessibleName, cont.Text, cont.AccessibleDescription) == "ok")
                    {
                        valid++;
                        cont.BackColor = Color.White;
                        cont.ForeColor = Color.Black;

                    }
                    else
                    {
                        errText += extraMethods.CheckInput(cont.AccessibleName, cont.Text, cont.AccessibleDescription);
                        cont.BackColor = Color.Red;
                        cont.ForeColor = Color.White;
                    }
                }
            }

            if (valid == panel1.Controls.Count / 2) { return true; }
            else {
                txtError.Text = errText;
                return false;
            }
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


    }
}
