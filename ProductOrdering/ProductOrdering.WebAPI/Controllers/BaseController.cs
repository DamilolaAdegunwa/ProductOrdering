using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using log4net;
namespace ProductOrdering.WebAPI.Controllers
{
    public class BaseController : Controller
    {
        public static string GetStatusCodeValue( HttpStatusCode code)
        {
            return ((int)code).ToString();
        }
        protected async Task<ServiceResponse<T>> HandleApiOperationAsync<T>(
       Func<Task<ServiceResponse<T>>> action, [CallerLineNumber] int lineNo = 0, [CallerMemberName] string method = "")
        {
            var _logger = LogManager.GetLogger(typeof(BaseController));

            _logger.Info($">>> ENTERS ({method}) >>> ");

            var serviceResponse = new ServiceResponse<T>
            {
                Code = GetStatusCodeValue(HttpStatusCode.OK),
                ShortDescription = "SUCCESS"
            };

            try
            {
                    if (!ModelState.IsValid)
                    {
                        throw new Exception($"There were errors in your input, please correct them and try again. {GetStatusCodeValue(HttpStatusCode.BadRequest)}");
                    }
                    var actionResponse = await action();

                    serviceResponse.Object = actionResponse.Object;
                    serviceResponse.ShortDescription = actionResponse.ShortDescription ?? serviceResponse.ShortDescription;
                    serviceResponse.Code = actionResponse.Code ?? serviceResponse.Code;

            }
            catch (Exception ex)
            {

                _logger.Warn($"L{lineNo} - {ex.Message}");

                serviceResponse.ShortDescription = ex.Message;
                serviceResponse.Code = GetStatusCodeValue(HttpStatusCode.InternalServerError);
                if (!ModelState.IsValid)
                {
                    serviceResponse.ValidationErrors = ModelState.ToDictionary(
                        m => {
                            var tokens = m.Key.Split('.');
                            return tokens.Length > 0 ? tokens[tokens.Length - 1] : tokens[0];
                        },
                        m => m.Value.Errors.Select(e => e.Exception?.Message ?? e.ErrorMessage)
                    );
                }
                _logger.Error(ex.Message, ex);
            }

            _logger.Info($"<<< EXITS ({method}) <<< ");

            return serviceResponse;
        }
    }
}
