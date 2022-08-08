using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage_UC1
    {
        public void EmployeePresentAbsent()
        {
            int IS_PRESENT = 1;      // Constant
            Random random = new Random(); // Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}