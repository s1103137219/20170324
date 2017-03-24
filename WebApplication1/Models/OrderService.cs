using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OrderService
    {
        
       public void InsertOrder(Models.Order order)
        {

        }
        public void DeleteOrderByID()
        {

        }
        public void UpdateOrder()
        {

        }
        public Models.Order GetOrderById(String id)
        {
            Models.Order result = new Order();
            result.CustId = "Gss";
            result.CustName = "叡揚";
            return result;
        }
        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }

    }
}