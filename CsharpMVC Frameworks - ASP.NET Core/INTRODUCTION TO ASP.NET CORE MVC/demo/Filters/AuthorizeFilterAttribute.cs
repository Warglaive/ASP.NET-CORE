using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace demo.Filters
{
    public class AuthorizeFilterAttribute : Attribute, IAsyncAuthorizationFilter
    {
        //put on controller as attribute so it works on current controller
        public Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            return Task.CompletedTask;
        }
    }
}