using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterForm
{
    public class Employee : User
    {
        public string Position { get; set; }
        public double Salary { get; set; }
    }
}
