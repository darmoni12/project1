using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    class Host
    {
        int HostKey;
        string PrivateName;
        string FamilyName;
        int PhoneNumber;
        string MailAddress;
        BankAccount HostBankAccount;
        Aproved CollectionClearance;
        public override string ToString()
        {
            return base.ToString();//
        }
    }
}
