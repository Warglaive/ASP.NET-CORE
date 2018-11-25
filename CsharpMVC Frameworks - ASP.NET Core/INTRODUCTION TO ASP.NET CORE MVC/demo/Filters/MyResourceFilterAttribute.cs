using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace demo.Filters
{
    public class MyResourceFilterAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            throw new NotImplementedException();
        }
    }
}