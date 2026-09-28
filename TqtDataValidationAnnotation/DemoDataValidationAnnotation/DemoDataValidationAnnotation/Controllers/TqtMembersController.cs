using DemoDataValidationAnnotation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDataValidationAnnotation.Controllers
{
    public class TqtMembersController : Controller
    {
        private static List<TqtMember> tqtMembers = new List<TqtMember>();

        // GET: TqtMembersController
        public ActionResult Index()
        {
            return View(tqtMembers);
        }

        // GET: TqtMembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TqtMembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TqtMembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TqtMember tqtMember)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(tqtMember);
                }

                //tqtMember.Id = tqtMember.Id;
                tqtMembers.Add(tqtMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TqtMembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TqtMembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TqtMembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TqtMembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
