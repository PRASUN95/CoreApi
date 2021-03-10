using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace CoreApi.Models
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = new Microsoft.AspNetCore.Mvc.JsonResult(new
            {
                message = context.Exception.Message.ToString(),
                stackTrace = context.Exception.StackTrace
            });
        }
    }
}
