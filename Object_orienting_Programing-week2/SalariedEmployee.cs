using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orienting_Programing_week2
{
    class SalariedEmployee
    {
        string firstName;
        string lastName;
        int socialSecurityNumber;

        int type;
        
        int salary;
        public SalariedEmployee(string firstName, string lastName, int socialSecurityNumber,int type, int salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
            this.type = type;
            this.salary = salary;
        }
        
    }
}

