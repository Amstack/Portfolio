using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using EntitledSiteAlpha.Models;
using EntitledSiteAlpha.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntitledSiteAlpha.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllInvoices()
        {

            InvoiceRepository InvoiceRepo = new InvoiceRepository();
            ModelState.Clear();
            return View(InvoiceRepo.GetAllInvoices());
        }

        public ActionResult GetAllNewInvoices()
        {
            InvoiceRepository InvoiceRepo = new InvoiceRepository();
            ModelState.Clear();
            return View(InvoiceRepo.GetAllNewInvoices());
        }

        public ActionResult GetAllOldInvoices()
        {
            InvoiceRepository InvoiceRepo = new InvoiceRepository();
            ModelState.Clear();
            return View(InvoiceRepo.GetAllOldInvoices());
        }

        // GET: Bank/AddBank    
        public ActionResult AddInvoice()
        {

            return View();
        }

        // POST: Bank/AddBank    
        [HttpPost]
        public ActionResult AddInvoice(InvoiceModel Invoice)
        {
            string userId = User.Identity.Name;
            InvoiceRepository InvoiceRepo = new InvoiceRepository();
            InvoiceRepo.AddInvoice(Invoice,userId);
            return RedirectToAction("GetAllBankDetails","Bank");
        }

        // GET: Bank/BankDetails/5    
        public ActionResult ApproveInvoice(int id)
        {
            InvoiceRepository InvoiceRepo = new InvoiceRepository();



            return View(InvoiceRepo.GetAllInvoices().Find(Inv => Inv.InvoiceID == id));

        }

        // POST: Bank/EditBankDetails/5    
        [HttpPost]

        public ActionResult ApproveInvoice(int id, InvoiceModel obj)
        {
            string userId = User.Identity.Name;
            InvoiceRepository InvoiceRepo = new InvoiceRepository();
            obj.InvoiceStatus = 1;
            InvoiceRepo.UpdateInvoiceStauts(obj,userId);
            InvoiceRepo.UpdateBankAndDKP(obj);
            return RedirectToAction("GetAllOldInvoices");
        }

        // GET: Bank/BankDetails/5    
        public ActionResult DenyInvoice(int id)
        {
            InvoiceRepository InvoiceRepo = new InvoiceRepository();



            return View(InvoiceRepo.GetAllInvoices().Find(Inv => Inv.InvoiceID == id));

        }

        // POST: Bank/EditBankDetails/5    
        [HttpPost]

        public ActionResult DenyInvoice(int id, InvoiceModel obj)
        {
            string userId = User.Identity.Name;
            InvoiceRepository InvoiceRepo = new InvoiceRepository();
            obj.InvoiceStatus = 2;
            InvoiceRepo.UpdateInvoiceStauts(obj,userId);
            return RedirectToAction("GetAllOldInvoices");
        }

        // GET: Invoice/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}