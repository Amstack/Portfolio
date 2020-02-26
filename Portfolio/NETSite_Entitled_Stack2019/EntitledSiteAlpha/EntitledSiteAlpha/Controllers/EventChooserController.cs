using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntitledSiteAlpha.Models;
using EntitledSiteAlpha.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EntitledSiteAlpha.Controllers
{
    public class EventChooserController : Controller
    {
        // GET: EventChooser
        public ActionResult Index()
        {
            return View();
        }

        // GET: EventChooser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult DKPForm(int id)
        {

            return View();
        }

        [HttpPost]
        public ActionResult DKPForm(EventChooser res)
        {
            PartRepository PartRepo = new PartRepository();
            RosterRepository RostRepo = new RosterRepository();
            string userId = User.Identity.Name;
            int currentDkp = RostRepo.GetAllRoster().Find(x => x.UserName.Equals(userId)).dkp;
            int addedDkp = 0;
            addedDkp += res.AQ;
            addedDkp += res.BWL;
            addedDkp += res.MoltenCore;
            addedDkp += res.Naxx;
            addedDkp += res.Onyxia;
            addedDkp += res.PVP;

            currentDkp += addedDkp;

            PartModel newPart = new PartModel();
            newPart.UserName = userId;
            newPart.dkp = currentDkp;
            PartRepo.UpdateDKP(newPart);

            return View();
        }

        // GET: EventChooser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventChooser/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventChooser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventChooser/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventChooser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventChooser/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}