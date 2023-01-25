using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object employee)
        {
            return base.Equals(employee);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator== (Employee Id1, Employee Id2)
        {
            if (Id1.Equals(Id2))
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee Id1, Employee Id2)
        {
            if (Id1.Equals(Id2))
                return false;
            else
                return true;
        }
    }
}
