using SmartCommerce.Application.Exceptions;
using System.Net;
using System.Text.Json;


namespace SmartCommerce.API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context); //move to next middleware
            }

            catch (AppException ex) {

                await HandleCustomException(context, ex);
            }

            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        public static Task HandleCustomException(HttpContext context, AppException ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = ex.StatusCode;
            var response = new
            {
                message = ex.Message,
                statusCode = ex.StatusCode
            };
            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var response = new { 
            
               message = "Something went wrong",
               detail = ex.Message,     
               statusCode = context.Response.StatusCode
            };
            return context.Response.WriteAsync(JsonSerializer.Serialize(response));           }
    }
}
