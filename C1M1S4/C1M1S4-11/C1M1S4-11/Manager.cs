using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1S4_11
{
    internal class Manager : Employee
    {
        private List<Employee> employees;

        internal List<Employee> Employees { get => employees; set => employees = value; }
    }
}
