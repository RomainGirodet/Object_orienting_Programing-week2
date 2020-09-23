using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orienting_Programing_week2
{
    class CommissionEmployee
    {
        string firstName;
        string lastName;
        int socialSecurityNumber;

        int type;
        
        int commission;
        int commissionRate;
        int sales;

        public CommissionEmployee(string firstName, string lastName, int socialSecurityNumber, int type, int commissionRate, int sales)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
            this.type = type;

            this.commissionRate = commissionRate;
            this.sales = sales;
            this.commission = this.sales * this.commissionRate;


        }
    }
}

