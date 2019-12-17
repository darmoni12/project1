using System;

namespace BE
{
    public class GuestRequest
    {
        int GuestRequestKey;
        string PrivateName;
        string FamilyName;
        string MailAddress;
        OrderStatus Status;
        DateTime RegistrationDate;
        DateTime EntryDate;
        DateTime ReleaseDate;
        Area Area;
        string SubArea;
        HostingType Type;
        int Adults;
        int Children;
        Require Pool;
        Require Jacuzzi;
        Require Garden;
        Require ChildrensAttractions;
        public override string ToString()
        {
            return base.ToString();//
        }
    }
}
