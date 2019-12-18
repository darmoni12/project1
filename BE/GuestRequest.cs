using System;

namespace BE
{
    public class GuestRequest
    {
        public int GuestRequestKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        OrderStatus Status;
        internal MyDate RegistrationDate { get; set; }
        internal MyDate EntryDate { get; set; }
        internal MyDate ReleaseDate { get; set; }
        Area Area;
        public string SubArea { get; set; }
        HostingType Type;
        public int Adults { get; set; }
        public int Children { get; set; }
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
