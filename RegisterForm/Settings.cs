using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterForm
{
    class Settings : Form1
    {
        // Clear inputs
        public void ClearInputs()
        {
            foreach (Control con in Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
            }
        }
    }
}
