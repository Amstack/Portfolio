using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntitledSiteAlpha;
using EntitledSiteAlpha.Controllers;
using Microsoft.AspNetCore.Mvc;
using EntitledSiteAlpha.Repository;
using EntitledSiteAlpha.Models;
using System.Data;
using System.Data.SqlClient;

namespace EntitledAlphaTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void BankControllerTest()
        {
            BankController controller = new BankController();

            ViewResult AddBankResult = controller.AddBank() as ViewResult;
            ViewResult EditBankResult =  controller.EditBankDetails(1) as ViewResult;
            ViewResult GetBankResult = controller.GetAllBankDetails() as ViewResult;

            Assert.IsNotNull(AddBankResult);
            Assert.IsNotNull(EditBankResult);
            Assert.IsNotNull(GetBankResult);
        }

        [TestMethod]
        public void EventChooserControllerTest()
        {
            EventChooserController controller = new EventChooserController();

            ViewResult DKPResult = controller.DKPForm(1) as ViewResult;

            Assert.IsNotNull(DKPResult);
        }

        [TestMethod]
        public void InvoiceControllerTest()
        {
            InvoiceController controller = new InvoiceController();

            ViewResult GetAllResult = controller.GetAllInvoices() as ViewResult;
            ViewResult GetNewResult = controller.GetAllNewInvoices() as ViewResult;
            ViewResult GetOldResult = controller.GetAllOldInvoices() as ViewResult;
            ViewResult AddResult = controller.AddInvoice() as ViewResult;
            ViewResult ApproveResult = controller.ApproveInvoice(1) as ViewResult;
            ViewResult DenyResult = controller.DenyInvoice(1) as ViewResult;

            Assert.IsNotNull(GetAllResult);
            Assert.IsNotNull(GetNewResult);
            Assert.IsNotNull(GetOldResult);
            Assert.IsNotNull(AddResult);
            Assert.IsNotNull(ApproveResult);
            Assert.IsNotNull(DenyResult);
        }

        [TestMethod]
        public void RosterControllerTest()
        {
            RosterController controller = new RosterController();

            ViewResult GetAllResult = controller.GetAllRosterDetails() as ViewResult;

            Assert.IsNotNull(GetAllResult);
        }

        [TestMethod]
        public void BankRepoTest()
        {
            BankRepository repo = new BankRepository();

            BankModel testValidItem = new BankModel();
            testValidItem.Count = 5;
            testValidItem.DKPCost = 8;
            testValidItem.GoldCost = 16;
            testValidItem.ItemID = 100;
            testValidItem.Link = "Test";
            testValidItem.Name = "Test Item";

            Assert.IsTrue(repo.AddItem(testValidItem));
            Assert.IsTrue(repo.UpdateBank(testValidItem));
            Assert.IsTrue(repo.UpdateBankItemCount(testValidItem));
            Assert.IsNotNull(repo.GetAllBankItems());
        }

        [TestMethod]
        public void InvoiceRepoTest()
        {
            InvoiceRepository repo = new InvoiceRepository();

            InvoiceModel testValidInvoice = new InvoiceModel();
            testValidInvoice.InvoiceID = 100;
            testValidInvoice.InvoiceItemCount = 2;
            testValidInvoice.InvoiceItemName = "TESTITEM";
            testValidInvoice.InvoiceStatus = 0;
            testValidInvoice.InvoiceType = 1;
            testValidInvoice.RequestUser = "Alex";
            testValidInvoice.ApproveUser = "Alex";

            Assert.IsTrue(repo.AddInvoice(testValidInvoice, "Alex"));
            Assert.IsNotNull(repo.GetAllInvoices());
            Assert.IsNotNull(repo.GetAllNewInvoices());
            Assert.IsNotNull(repo.GetAllOldInvoices());
            Assert.IsNotNull(repo.GetInvoiceCount());
            Assert.IsTrue(repo.UpdateBankAndDKP(testValidInvoice));
            Assert.IsTrue(repo.UpdateInvoiceStauts(testValidInvoice,"Alex"));
        }

        [TestMethod]
        public void PartRepoTest()
        {
            PartRepository repo = new PartRepository();

            PartModel testValidPart = new PartModel();
            testValidPart.dkp = 100;
            testValidPart.UserName = "Alex";

            Assert.IsTrue(repo.UpdateDKP(testValidPart));
        }

        [TestMethod]
        public void RosterRepoTest()
        {
            RosterRepository repo = new RosterRepository();

            RosterModel testValidRoster = new RosterModel();
            testValidRoster.dkp = 100;
            testValidRoster.numDonations = 5;
            testValidRoster.UserName = "Alex";

            Assert.IsNotNull(repo.GetAllRoster());
            Assert.IsNotNull(repo.UpdateUserDonations(testValidRoster.UserName, testValidRoster.numDonations));
        }
    }
}
