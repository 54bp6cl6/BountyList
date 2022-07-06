using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BountyList.MVC.Filters;

namespace BountyList.MVC.Controllers.Base
{
    [AuthenticateFilter]
    public class BaseController : Controller
    {
        protected IWebHostEnvironment HostingEnvironment { get; init; }
        protected IConfiguration Configuration { get; init; }

        public SessionAccountInfo? SessionAccountInfo
        {
            get
            {
                var sessionString = HttpContext.Session.GetString(GlobalVars.SessionAccountInfo);
                return sessionString == null ? null : JsonSerializer.Deserialize<SessionAccountInfo>(sessionString);
            }
            set
            {
                HttpContext.Session.SetString(GlobalVars.SessionAccountInfo, JsonSerializer.Serialize(value));
            }
        }

        public BaseController(BaseControllerInitArgument initArgument)
        {
            HostingEnvironment = initArgument.HostingEnvironment;
            Configuration = initArgument.Configuration;
        }
    }

    public class BaseControllerInitArgument
    {
        public IWebHostEnvironment HostingEnvironment { get; set; }
        public IConfiguration Configuration { get; set; }

        public BaseControllerInitArgument(IWebHostEnvironment hostingEnvironment, IConfiguration configuration)
        {
            HostingEnvironment = hostingEnvironment;
            Configuration = configuration;
        }
    }
}
