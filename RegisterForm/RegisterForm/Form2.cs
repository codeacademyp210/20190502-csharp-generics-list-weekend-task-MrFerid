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
    public partial class Form2 : Form
    {
        List<Employee> deletedList = new List<Employee>();

        int rowId = 0; // id of selected row
        public Form2(List<Employee> list)
        {
            InitializeComponent();
            deletedList = list;
            RefreshGrid();
        }

        // Selecting rows
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            rowId = Convert.ToInt32(e.Row.Cells[0].Value);
        }

        // Writing List to grid
        public void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < deletedList.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = deletedList[i].Name;
                row.Cells[1].Value = deletedList[i].Surname;
                row.Cells[2].Value = deletedList[i].Position;
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
