using Newtonsoft.Json;
using ProductOrdering.Core.Model;
using ProductOrdering.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Org.BouncyCastle.Asn1.Ocsp;

namespace ProductOrdering.BusinessLogic.Services
{
    public interface IOrderService
    {
        Task<OrderResponse> BuyProduct(OrderRequest request);
        Task<bool> PrintReceipt(long PaymentId);
        Task<bool> SendInvoice(long OrderId);
    }
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        private readonly IServiceHelper _serviceHelper;
        public OrderService(IUnitOfWork unitOfWork, IServiceHelper serviceHelper)
        {
            _unitOfWork = unitOfWork;
            _serviceHelper = serviceHelper;
        }

        public async Task<OrderResponse> BuyProduct(OrderRequest request)
        {
            int retry = 0; int retries = 2;
            retry:
            string username = _serviceHelper.GetCurrentUserEmail();
            try
            {
                return default;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                log.Error($"user ({username}) could not add a new ad {ex.Message} :: {MethodBase.GetCurrentMethod().Name} :: {ex.StackTrace} :: payload {JsonConvert.SerializeObject(request)}");
                if (retry < retries)
                {
                    retry++;
                    goto retry;
                }
                throw ex;
            }
            //throw new NotImplementedException();
        }

        public async Task<bool> PrintReceipt(long PaymentId)
        {
            int retry = 0; int retries = 2;
        retry:
            string username = _serviceHelper.GetCurrentUserEmail();
            try
            {
                return default;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                log.Error($"user ({username}) could not add a new ad {ex.Message} :: {MethodBase.GetCurrentMethod().Name} :: {ex.StackTrace} :: payload {PaymentId}");
                if (retry < retries)
                {
                    retry++;
                    goto retry;
                }
                throw ex;
            }
            //throw new NotImplementedException();
        }

        public async Task<bool> SendInvoice(long OrderId)
        {
            int retry = 0; int retries = 2;
        retry:
            string username = _serviceHelper.GetCurrentUserEmail();
            try
            {
                return default;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                log.Error($"user ({username}) could not add a new ad {ex.Message} :: {MethodBase.GetCurrentMethod().Name} :: {ex.StackTrace} :: payload {OrderId}");
                if (retry < retries)
                {
                    retry++;
                    goto retry;
                }
                throw ex;
            }
            //throw new NotImplementedException();
        }
    }
}
