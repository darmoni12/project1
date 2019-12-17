using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Order
    {
        int HostingUnitKey;
        int GuestRequestKey;
        int OrderKey;
        OrderStatus Status;
        DateTime CreateDate;
        DateTime OrderDate;
        public override string ToString()
        {
            return base.ToString();//
        }
    }
}
