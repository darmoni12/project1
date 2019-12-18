using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Host
    {
        public int HostKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public int PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        BankAccount HostBankAccount { get; set; }
        Aproved CollectionClearance;
        public override string ToString()
        {
            return base.ToString();//
        }
    }
}
