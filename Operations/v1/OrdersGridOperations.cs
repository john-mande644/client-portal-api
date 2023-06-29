using ClientPortal_API.DTOs.v1;
using ClientPortal_API.Schemas.v1;
using ClientPortal_API.Services.v1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClientPortal_API.Operations.v1
{
    [ApiController]
    [Route("api/client-portal/v1/orders")]
    [Authorize]
    public class OrdersGridOperations : ControllerBase
    {
        private readonly IGridService<GridDTO.GetOrder> _orderGridService;
        private readonly ILogger<DashboardOperations> _log;

        [HttpGet("client/{client_id}")]
        public async Task<ActionResult<List<GridDTO.GetOrder>>> GetOrders(int client_id)
        {
            _log.LogInformation($"Request received to get the Client Dashboard. Client Id: {client_id}");

            try
            {
                string? clientId = User.Claims.Where(c => c.Type == "client_id").Select(x => x.Value).FirstOrDefault();
                
                if (clientId != client_id.ToString())
                {
                    throw new UnauthorizedAccessException($"You are not authorized to view this resource.");
                }

                var orders = await _orderGridService.GetItemsAsync(client_id);

                return new OkObjectResult(orders);
            }
            catch (UnauthorizedAccessException ex)
            {
                List<API.ErrorResponse> errors = new List<API.ErrorResponse>
                {
                    new API.ErrorResponse
                    {
                        errorCode = "ORDERS_GET",
                        errorDetails = $"An error occurred while retrieving Orders for Client Id: {client_id}",
                        errorMessage = "Error retrieving Orders.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "ORDERS_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                var errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                var error = new ObjectResult(errorResponses)
                {
                    StatusCode = 401
                };

                return error;
            }
            catch (Exception ex)
            {
                _log.LogError(ex, ex.Message);

                if (ex.Message.Contains("not found") || ex.Message.Contains("does not exist"))
                {
                    return new NotFoundResult();
                }

                List<API.ErrorResponse> errors = new List<API.ErrorResponse>
                {
                    new API.ErrorResponse
                    {
                        errorCode = "ORDERS_GET",
                        errorDetails = $"An error occurred while retrieving Orders for Client Id: {client_id}",
                        errorMessage = "Error retrieving Orders.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "ORDERS_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                var errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                var error = new ObjectResult(errorResponses)
                {
                    StatusCode = 500
                };

                return error;
            }
        }



    }    
}

