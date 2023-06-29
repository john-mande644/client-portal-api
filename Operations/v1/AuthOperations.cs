using Microsoft.AspNetCore.Mvc;
using ClientPortal_API.Services.v1;
using ClientPortal_API.DTOs.v1;
using Microsoft.AspNetCore.Authorization;
using ClientPortal_API.Schemas.v1;
using Microsoft.Extensions.Primitives;

namespace ClientPortal_API.Operations.v1
{
    [ApiController]
    [Route("api/client-portal/v1/auth")]
    [Authorize]
    public class AuthOperations : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthOperations> _log;

        public AuthOperations(IAuthService authService, ILogger<AuthOperations> log)
        {
            _authService = authService;
            _log = log;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<AuthDTO.GetJwtToken>> PostAuthorize(AuthDTO.PostLoginCredentials credentials)
        {
            _log.LogInformation("Request recieved to authorize user");

            try
            {
                // Content Type
                if (Request.Headers.TryGetValue("content-type", out StringValues contentType))
                {
                    if (contentType.Equals("application/json").Equals(false))
                    {
                        return new BadRequestResult();
                    }
                }
                else
                {
                    return new BadRequestResult();
                }

                AuthDTO.GetJwtToken token = await _authService.Authenticate(credentials);

                if (token == null)
                {
                    throw new UnauthorizedAccessException($"No user found with the provided credentials");
                }

                return Ok(token);
            }
            catch (UnauthorizedAccessException ex)
            {
                List<API.ErrorResponse> errors = new List<API.ErrorResponse>
                {
                    new API.ErrorResponse
                    {
                        errorCode = "AUTHORIZE_POST",
                        errorDetails = $"An error occurred while authorizing user",
                        errorMessage = "Error authorizing user",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "AUTHORIZE_POST",
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
                        errorCode = "AUTHORIZE_POST",
                        errorDetails = $"An error occurred while generating a JWT for user",
                        errorMessage = "Error generating JWT for user.",
                        errorInfoUrl = null
                    },
                    new API.ErrorResponse
                    {
                        errorCode = "AUTHORIZE_POST",
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
