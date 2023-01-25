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

            Employee employee3 = new Employee();
            employee3.Id = 123;
            employee3.FirstName = "John";
            employee3.LastName = "Jingle";

            Console.WriteLine(employee1.Id.Equals(employee2.Id) ? "They are the same person" : "They are not the same person");
            Console.WriteLine(employee1.Id == employee2.Id ? "They are the same person" : "They are not the same person");
            Console.ReadLine();
            //Should both return they are not the same person

            Console.WriteLine(employee1.Id.Equals(employee3.Id) ? "They are the same person" : "They are not the same person");
            Console.WriteLine(employee1.Id == employee3.Id ? "They are the same person" : "They are not the same person");
            Console.ReadLine();
            //Should both return they are the same person


        }
    }
}
