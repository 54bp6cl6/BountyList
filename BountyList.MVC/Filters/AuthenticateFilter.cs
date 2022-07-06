using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BountyList.MVC.Filters
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthenticateFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool allowAnonymous = context.ActionDescriptor.EndpointMetadata
                .Any(em => em.GetType() == typeof(AllowAnonymousAttribute)); //< -- Here it is
            if (!allowAnonymous && context.HttpContext.Session.GetString(GlobalVars.SessionAccountInfo) == null)
                context.Result = new RedirectResult("/Account/Login");
        }
    }
}
