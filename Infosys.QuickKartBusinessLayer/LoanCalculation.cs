using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class LoanCalculation
    {
        public bool ApplyForLoan(float salary, out int loanAmount, out int interest, params String[] doc)
        {
            if(doc.Length>=2 && Array.Exists(doc,element=>element=="Passport"))
            {
                if (salary > 12000)
                {
                    loanAmount = 25000;
                    interest = 4;
                }
                else if(salary>=12000 && salary <= 50000)
                {
                    loanAmount = 50000;
                    interest = 6;
                }
                else
                {
                    loanAmount = 100000;
                    interest = 8;
                }
                return true;
            }
            else
            {
                loanAmount = 0;
                interest = 0;
                return false;
            }
        }
        public void Emi_Discount(int loanAmount, int relativeMarking, int tenure, int interest, out int emi)
        {
            emi = (loanAmount + (loanAmount * interest / 100)) / tenure;
            int discount = 0;
            if (relativeMarking == 1)
                discount = 10;
            else if (relativeMarking == 2)
                discount = 8;
            else if (relativeMarking == 3)
                discount = 6;
            else if (relativeMarking > 3)
                discount = 4;
            emi = emi - (emi * discount / 100);
        }
        public void SalaryDeduction(ref float salary, int relativeMarking, int loanAmount, int tenure, int interest, out int emi)
        {
            Emi_Discount(loanAmount, relativeMarking, tenure, interest, out emi);
            salary -= emi;
        }
    }
}
