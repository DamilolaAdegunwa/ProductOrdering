using ProductOrdering.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrdering.BusinessLogic.Services
{
    public interface IOrderService
    {
        OrderResponse BuyProduct(OrderRequest request);
        Task<bool> PrintReceipt(long PaymentId);
        Task<bool> SendInvoice(long OrderId);
    }
    public class OrderService : IOrderService
    {

        public OrderService()
        {

        }

        public OrderResponse BuyProduct(OrderRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PrintReceipt(long PaymentId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendInvoice(long OrderId)
        {
            throw new NotImplementedException();
        }
    }
}
