using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BankAccount
    {
        int BankNumber;
        string BankName;
        int BranchNumber;
        string BranchAddress;
        string BranchCity;
        int BankAccountNumber;
        public override string ToString()
        {
            return base.ToString();//
        }
    }
}
