using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    public class Employee
    {
        public string Id { get; set; }
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

        public static bool operator== (Employee Id, Employee FirstName)
        {
            if (Id.Equals(FirstName))
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee Id, Employee FirstName)
        {
            if (Id.Equals(FirstName))
                return false;
            else
                return true;
        }
    }
}
