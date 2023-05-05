using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWithDelegates
{
    public class Finance
    {
        public Finance(OrderProcessor orderProcessor)
        {
            orderProcessor.OrderConfirmed += OnOrderConfirmedExpectFunds;
        }

        private void OnOrderConfirmedExpectFunds(Order order)
        {
            Console.WriteLine("Order made for " + order.CustomerName + 
                " - Expect payment");
        }
    }
}
