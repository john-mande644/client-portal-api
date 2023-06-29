using Microsoft.AspNetCore.Mvc;
using ClientPortal_API.Schemas.v1;
using ClientPortal_API.Services.v1;
using ClientPortal_API.DTOs.v1;
using Microsoft.AspNetCore.Authorization;

namespace ClientPortal_API.Operations.v1
{
    [ApiController]
    [Route("api/client-portal/v1/dashboard")]
    [Authorize]
    public class DashboardOperations : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        private readonly ILogger<DashboardOperations> _log;
        public DashboardOperations(IDashboardService dashboardService, ILogger<DashboardOperations> log)
        {
            _dashboardService = dashboardService;
            _log = log;
        }

        [HttpGet("client/{client_id}")]
        public async Task<ActionResult<DashboardDTO.GetClient>> GetClientDashboard(int client_id) {

            _log.LogInformation($"Request received to get the Client Dashboard. Client Id: {client_id}");

            try
            {
                string? clientId = User.Claims.Where(c => c.Type == "client_id").Select(x => x.Value).FirstOrDefault();
                
                if (clientId != client_id.ToString())
                {
                    throw new UnauthorizedAccessException($"You are unathorized to view this resource. Client Id: {client_id}");
                }

                DashboardDTO.GetClient dashboard = await _dashboardService.GetClientDashboard(client_id);

                return new OkObjectResult(dashboard);
            }
            catch (UnauthorizedAccessException ex)
            {
                List<API.ErrorResponse> errors = new List<API.ErrorResponse>
                {
                    new API.ErrorResponse
                    {
                        errorCode = "CLIENT_DASHBOARD_GET",
                        errorDetails = $"An error occurred while retrieving Client Dashboard for Clint Id: {client_id}",
                        errorMessage = "Error retrieving Dashboard.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "CLIENT_DASHBOARD_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                API.ErrorResponses errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                ObjectResult error = new ObjectResult(errorResponses)
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
                        errorCode = "CLIENT_DASHBOARD_GET",
                        errorDetails = $"An error occurred while retrieving Client Dashboard for Clint Id: {client_id}",
                        errorMessage = "Error retrieving Dashboard.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "CLIENT_DASHBOARD_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                API.ErrorResponses errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                ObjectResult error = new ObjectResult(errorResponses)
                {
                    StatusCode = 500
                };

                return error;
            }
        }

        [HttpGet("sales-orders/{client_id}")]
        public async Task<ActionResult<DashboardDTO.GetSalesOrders>> GetSalesOrdersDashboard(int client_id)
        {
            _log.LogInformation($"Request received to get the Sales Orders Dashboard. Client Id: {client_id}");

            try
            {
                string? clientId = User.Claims.Where(c => c.Type == "client_id").Select(x => x.Value).FirstOrDefault();

                if (clientId != client_id.ToString())
                {
                    throw new UnauthorizedAccessException($"You are unathorized to view this resource. Client Id: {client_id}");
                }

                DashboardDTO.GetSalesOrders dashboard = await _dashboardService.GetSalesOrdersDashboard(client_id);

                return new OkObjectResult(dashboard);
            }
            catch (UnauthorizedAccessException ex)
            {
                List<API.ErrorResponse> errors = new List<API.ErrorResponse>
                {
                    new API.ErrorResponse
                    {
                        errorCode = "SALES_ORDERS_DASHBOARD_GET",
                        errorDetails = $"An error occurred while retrieving Sales Orders Dashboard for Clint Id: {client_id}",
                        errorMessage = "Error retrieving Return Order.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "SALES_ORDERS_DASHBOARD_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                API.ErrorResponses errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                ObjectResult error = new ObjectResult(errorResponses)
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
                        errorCode = "SALES_ORDERS_DASHBOARD_GET",
                        errorDetails = $"An error occurred while retrieving Sales Orders Dashboard for Clint Id: {client_id}",
                        errorMessage = "Error retrieving Dashboard.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "SALES_ORDERS_DASHBOARD_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                API.ErrorResponses errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                ObjectResult error = new ObjectResult(errorResponses)
                {
                    StatusCode = 500
                };

                return error;
            }
        }

        [HttpGet("asn-inventory/{client_id}")]
        public async Task<ActionResult<DashboardDTO.GetAsnInventory>> GetAsnInventoryDashboard(int client_id)
        {
            _log.LogInformation($"Request received to get the Asn and Inventory Dashboard. Client Id: {client_id}");

            try
            {
                string? clientId = User.Claims.Where(c => c.Type == "client_id").Select(x => x.Value).FirstOrDefault();

                if (clientId != client_id.ToString())
                {
                    throw new UnauthorizedAccessException($"You are unathorized to view this resource. Client Id: {client_id}");
                }

                DashboardDTO.GetAsnInventory dashboard = await _dashboardService.GetAsnInventoryDashboard(client_id);

                return new OkObjectResult(dashboard);
            }
            catch (UnauthorizedAccessException ex)
            {
                List<API.ErrorResponse> errors = new List<API.ErrorResponse>
                {
                    new API.ErrorResponse
                    {
                        errorCode = "ASN_INVENTORY_DASHBOARD_GET",
                        errorDetails = $"An error occurred while retrieving Asn and Inventory Dashboard for Clint Id: {client_id}",
                        errorMessage = "Error retrieving Return Order.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "ASN_INVENTORY_DASHBOARD_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                API.ErrorResponses errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                ObjectResult error = new ObjectResult(errorResponses)
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
                        errorCode = "ASN_INVENTORY_DASHBOARD_GET",
                        errorDetails = $"An error occurred while retrieving Sales Orders Dashboard for Clint Id: {client_id}",
                        errorMessage = "Error retrieving Dashboard.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "ASN_INVENTORY_DASHBOARD_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                API.ErrorResponses errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                ObjectResult error = new ObjectResult(errorResponses)
                {
                    StatusCode = 500
                };

                return error;
            }
        }

        [HttpGet("returns/{client_id}")]
        public async Task<ActionResult<DashboardDTO.GetReturns>> GetReturnsDashboard(int client_id)
        {
            _log.LogInformation($"Request received to get the Returns Dashboard. Client Id: {client_id}");

            try
            {
                string? clientId = User.Claims.Where(c => c.Type == "client_id").Select(x => x.Value).FirstOrDefault();

                if (clientId != client_id.ToString())
                {
                    throw new UnauthorizedAccessException($"You are unathorized to view this resource. Client Id: {client_id}");
                }

                DashboardDTO.GetAsnInventory dashboard = await _dashboardService.GetAsnInventoryDashboard(client_id);

                return new OkObjectResult(dashboard);
            }
            catch (UnauthorizedAccessException ex)
            {
                List<API.ErrorResponse> errors = new List<API.ErrorResponse>
                {
                    new API.ErrorResponse
                    {
                        errorCode = "RETURNS_DASHBOARD_GET",
                        errorDetails = $"An error occurred while retrieving the Returns Dashboard for Client Id: {client_id}",
                        errorMessage = "Error retrieving Return Order.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "RETURNS_DASHBOARD_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                API.ErrorResponses errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                ObjectResult error = new ObjectResult(errorResponses)
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
                        errorCode = "RETURNS_DASHBOARD_GET",
                        errorDetails = $"An error occurred while retrieving the Returns Dashboard for Client Id: {client_id}",
                        errorMessage = "Error retrieving Dashboard.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "RETURNS_DASHBOARD_GET",
                        errorDetails = ex.InnerException?.Message,
                        errorMessage = ex.Message,
                        errorInfoUrl = null
                    }
                };

                API.ErrorResponses errorResponses = new API.ErrorResponses()
                {
                    errorResponses = errors.ToArray()
                };

                ObjectResult error = new ObjectResult(errorResponses)
                {
                    StatusCode = 500
                };

                return error;
            }
        }
    }
}
