    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orienting_Programing_week2
{
    class SalariedCommissionEmployee
    {
        string firstName;
        string lastName;
        int socialSecurityNumber;

        int type;

        
        int salary;

        int sales;
        int commissionRate;
        int commission;

        int totalEarn;

        public SalariedCommissionEmployee(string firstName, string lastName, int socialSecurityNumber, int type, int comissionRate, int sales)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
            this.type = type;
            this.commissionRate = comissionRate;
            this.sales = sales;
            this.commission = this.sales*this.commissionRate;
            

        }
    }
}
