using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); // instantiate the class

            employee1.Id = 123;
            employee1.FirstName = "Mark";
            employee1.LastName = "Smith";

            Employee employee2 = new Employee();

            employee2.Id = 456;
            employee2.FirstName = "Lauren";
            employee2.LastName = "Smith";


        }
    }
}
