using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class CWageData
    {
        public string Company
        {
            get { return Company; }
            set { Company = value; }
        }

        public double Wage
        {
            get { return Wage; }
            set { Wage = value; }
        }

        public CWageData(string param_Company, double param_Wage)
        {
            Company = param_Company;
            Wage = param_Wage;
        }
    }
}
