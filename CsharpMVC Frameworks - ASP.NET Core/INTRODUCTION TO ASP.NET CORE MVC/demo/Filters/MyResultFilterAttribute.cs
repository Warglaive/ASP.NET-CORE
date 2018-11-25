using Microsoft.AspNetCore.Mvc.Filters;

namespace demo.Filters
{
    public class MyResultFilterAttribute : ResultFilterAttribute
    {
        //before action execution
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);
        }
        //after action execution
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            base.OnResultExecuted(context);
        }
    }
}