using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class HostingUnit
    {
        int HostingUnitKey;
        Host Owner;
        string HostingUnitName;
        bool [,] Diary;
        public override string ToString()
        {
            return base.ToString();//
        }
    }
}
