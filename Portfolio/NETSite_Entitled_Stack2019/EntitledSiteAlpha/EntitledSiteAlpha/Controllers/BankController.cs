using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntitledSiteAlpha.Models;
using EntitledSiteAlpha.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntitledSiteAlpha.Controllers
{
    public class BankController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
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

        [Authorize]
        // GET: Bank/GetAllBankDetails   
        public ActionResult GetAllBankDetails()
        {

            BankRepository BankRepo = new BankRepository();
            ModelState.Clear();
            return View(BankRepo.GetAllBankItems());
        }

        // GET: Bank/AddBank    
        public ActionResult AddBank()
        {
            return View();
        }

        // POST: Bank/AddBank    
        [HttpPost]
        public ActionResult AddBank(BankModel Bank)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BankRepository BankRepo = new BankRepository();

                    if (BankRepo.AddItem(Bank))
                    {
                        ViewBag.Message = "New item details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Bank/BankDetails/5    
        public ActionResult EditBankDetails(int id)
        {
            BankRepository BankRepo = new BankRepository();



            return View(BankRepo.GetAllBankItems().Find(Bank => Bank.ItemID == id));

        }

        // POST: Bank/EditBankDetails/5    
        [HttpPost]

        public ActionResult EditBankDetails(int id, BankModel obj)
        {
            try
            {
                BankRepository BankRepo = new BankRepository();

                BankRepo.UpdateBank(obj);




                return RedirectToAction("GetAllBankDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bank/DeleteBank/5    
        public ActionResult DeleteItem(int id)
        {
            try
            {
                BankRepository BankRepo = new BankRepository();
                if (BankRepo.DeleteBankEntry(id))
                {
                    ViewBag.AlertMsg = "Bank details deleted successfully";

                }
                return RedirectToAction("GetAllBankDetails");

            }
            catch
            {
                return View();
            }
        }


    }
}