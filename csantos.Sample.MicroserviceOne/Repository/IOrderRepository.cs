using csantos.Sample.MicroserviceOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csantos.Sample.MicroserviceOne.Repository
{
    public interface IOrderRepository
    {
        Task<string> Add(Order order);
        Task<Order> GetById(string id);
        Task<string> Cancel(string id);
        Task<Order> GetByCustomerId(string custid);

        //IEnumerable<Order> GetAllOrders();
    }
}
