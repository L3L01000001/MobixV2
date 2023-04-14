using Microsoft.AspNetCore.Mvc;
using Mobix.Data;

namespace Mobix.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CartController : ControllerBase
    {
        private readonly MobixDbContext _db;

        public CartController(MobixDbContext db)
        {
            _db = db;
        }
    }
}
