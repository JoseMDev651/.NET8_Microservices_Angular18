using Microsoft.AspNetCore.Http;
using System.Net;

namespace eCommerce.SharedLibrary.Middleware
{
    public class GlobalException(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            //Declare variables
            string message = "Sorry, internal server error occurred. Kindly try again,";
            int statusCode = (int)HttpStatusCode.InternalServerError;
            string title = "Error";

            try
            {
                await next(context);

                //Check if Exception is too many request // 429 status code
                if(context.Response.StatusCode == StatusCodes.Status429TooManyRequests)
                {
                    title = "Warning";
                    message = "Too many request made.";
                    statusCode = (int)StatusCodes.Status429TooManyRequests;

                    await ModifyHeader(context, title, message, statusCode);
                }
            }
        }

        private async Task ModifyHeader(HttpContext context, string title, string message, int statusCode)
        {
            //Display a scary-free message to client
        }
    }
}
