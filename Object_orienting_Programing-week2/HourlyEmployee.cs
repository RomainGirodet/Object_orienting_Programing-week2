using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orienting_Programing_week2
{
    class HourlyEmployee
    {
        string firstName;
        string lastName;
        int socialSecurityNumber;

        int type;

        int timeWorked;
        int moneyperHours;
        int salary;
        public HourlyEmployee(string firstName, string lastName, int socialSecurityNumber, int type, int timeWorked,int moneyperHours)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
            this.type = type;
            this.timeWorked = timeWorked;
            this.moneyperHours = moneyperHours;
            

        }

    }
}
