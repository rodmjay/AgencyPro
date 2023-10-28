using System;

namespace AgencyPro.Orders.Interfaces
{
    public interface IOrderProcessor
    {
        void Process(Guid order);
    }
}
