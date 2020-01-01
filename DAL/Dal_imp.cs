using System;
using System.Collections.Generic;
using System.Text;
using BE;
using DS;

namespace DAL
{
    class Dal_imp : Idal
    {
        public void addHostingUnit(HostingUnit unit)
        {
            DataSource.hostingUnits
        }

        public void addOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void addRequest(GuestRequest request)
        {
            throw new NotImplementedException();
        }

        public void deleteHostingUnit(HostingUnit unit)
        {
            throw new NotImplementedException();
        }

        public List<BankBranch> getAllBranches()
        {
            throw new NotImplementedException();
        }

        public List<GuestRequest> getAllGuestRequest()
        {
            throw new NotImplementedException();
        }

        public List<Order> getAllOrder()
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> getAllUnits()
        {
            throw new NotImplementedException();
        }

        public void updateHostingUnit(HostingUnit unit)
        {
            throw new NotImplementedException();
        }

        public void updateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void updateRequest(GuestRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
