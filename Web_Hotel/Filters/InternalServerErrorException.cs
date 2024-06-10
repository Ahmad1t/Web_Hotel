using Microsoft.AspNetCore.Diagnostics;

namespace Web_Hotel.Filters
{
    public class InternalServerErrorException : IExceptionHandler
    {
   

        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
