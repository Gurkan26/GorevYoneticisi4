using GorevYoneticisi4.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GorevYoneticisi4.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db = new AppDbContext();

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult gorevGetir()
        {
            var gorevler = db.Gorevler.ToList(); // gorevleri aldık
            return new JsonResult(gorevler);// json tipine çevirip gönderdik

        }
        [HttpPost]
        public JsonResult addRequest([FromBody] Gorevler gorevler)
        {
            db.Gorevler.Add(gorevler);
            db.SaveChanges();
            return new JsonResult(gorevler);
        }
        [HttpPost]
        public JsonResult Delete([FromBody] int id)
        {
            var gorevler = db.Gorevler.ToList();
            var gorev = gorevler.FirstOrDefault(x => x.id == id);

            if (gorev != null)
            {
                db.Gorevler.Remove(gorev);
                db.SaveChanges();

            }
            return new JsonResult(gorevler);
        }
    }
}

