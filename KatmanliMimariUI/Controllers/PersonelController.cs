using KatmanliMimariEntity;
using KatmanliMimariUow;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimariUI.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IUnitofWork _uw;
        public PersonelController(IUnitofWork uw)
        {
            _uw = uw;
        }
        public IActionResult List()
        {
            var ls = _uw._personelRep.List();
            return View(ls);
        }
        public IActionResult Create()
        {
            Personel p = new Personel();
            return View(p);
        }
        [HttpPost]
        public IActionResult Create(Personel p)
        {
            _uw._personelRep.Add(p);
            _uw.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int Id)
        {
            var p = _uw._personelRep.Find(Id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Edit(Personel p)
        {
            _uw._personelRep.Update(p);
            _uw.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            var p = _uw._personelRep.Find(Id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Delete(Personel p)
        {
            _uw._personelRep.Delete(p);
            _uw.Commit();
            return RedirectToAction("List");
        }
    }
}
