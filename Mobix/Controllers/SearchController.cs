using Microsoft.AspNetCore.Mvc;
using Mobix.Data;
using MobixWebShop.EntityModels;

namespace Mobix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly MobixDbContext _db;

        public SearchController(MobixDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<List<Proizvod>> Search(string proizvodSearch)
        {
            var prozivodi = _db.Proizvodi
                .Where(p => proizvodSearch == null || (p.Naziv).StartsWith(proizvodSearch))
                .OrderByDescending(p => p.ProizvodID)
                .AsQueryable();
            return prozivodi.ToList();
        }
    }
}
