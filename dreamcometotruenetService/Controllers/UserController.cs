using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using dreamcometotruenetService.DataObjects;
using dreamcometotruenetService.Models;

namespace dreamcometotruenetService.Controllers
{
    public class UserController : TableController<User>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            dreamcometotruenetContext context = new dreamcometotruenetContext();
            DomainManager = new EntityDomainManager<User>(context, Request, Services);
        }

        // GET api/User
        public IQueryable<User> GetUsers()
        {
            return Query();
        }

        
    }
}