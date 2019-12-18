using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    interface Idal
    {
        void addRequest(GuestRequest request);
        void updateRequest(GuestRequest request);

        void addHostingUnit(HostingUnit unit);
        void deleteHostingUnit(HostingUnit unit);
        void updateHostingUnit(HostingUnit unit);

        void addOrder(HostingUnit unit);
        void updateOrder(HostingUnit unit);

        List<HostingUnit> getAllUnits();
        //List<> getAllCustomer();
        List<Order> getAllOrder();

        //List<> getAllBranches();
    }
}