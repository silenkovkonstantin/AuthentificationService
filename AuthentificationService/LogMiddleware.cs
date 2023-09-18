namespace AuthentificationService
{
    public class LogMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;


        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;

        }

        public async Task Invoke(HttpContext httpContext)
        {
            ///ответ из модуля 34
            _logger.WriteEvent("IP-адрес клиента: " + httpContext.Connection.RemoteIpAddress.ToString());


            await _next(httpContext);
        }
    }
}
