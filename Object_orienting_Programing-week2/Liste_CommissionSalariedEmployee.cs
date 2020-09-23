using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orienting_Programing_week2
{
    class Liste_CommissionSalariedEmployee
    {
        List<SalariedCommissionEmployee> listCSE = new List<SalariedCommissionEmployee>();

        public Liste_CommissionSalariedEmployee(List<SalariedCommissionEmployee> listCSE)
        {
            this.listCSE = listCSE;
        }
    }
}
