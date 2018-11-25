using Microsoft.AspNetCore.Mvc.Filters;

namespace demo.Filters
{
    public class MyExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
        }
    }
}