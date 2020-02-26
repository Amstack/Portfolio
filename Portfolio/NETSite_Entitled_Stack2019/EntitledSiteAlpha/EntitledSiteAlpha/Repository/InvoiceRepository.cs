using EntitledSiteAlpha.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntitledSiteAlpha.Repository;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Web.Providers.Entities;

namespace EntitledSiteAlpha.Repository
{
    public class InvoiceRepository
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            con = new SqlConnection("Data Source=localhost;Initial Catalog=EntitledDB;Integrated Security=True");

        }

        [HttpPost]
        //To Add Invoice to Invoices    
        public bool AddInvoice(InvoiceModel obj, string userId)
        {
            connection();
            SqlCommand com = new SqlCommand("AddInvoices", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@InvoiceID", GetInvoiceCount() + 1);
            com.Parameters.AddWithValue("@InvoiceType", obj.InvoiceType);
            com.Parameters.AddWithValue("@ItemName", obj.InvoiceItemName);
            com.Parameters.AddWithValue("@ItemCount", obj.InvoiceItemCount);
            com.Parameters.AddWithValue("@RequestUser", userId);
            com.Parameters.AddWithValue("@InvoiceStatus",0);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }

        public List<InvoiceModel> GetAllOldInvoices()
        {
            connection();
            List<InvoiceModel> InvoiceList = new List<InvoiceModel>();


            SqlCommand com = new SqlCommand("GetOldInvoices", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind InvoiceModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    InvoiceList.Add(

                        new InvoiceModel
                        {
                            InvoiceID = Convert.ToInt32(dr["InvoiceID"]),
                            InvoiceType = Convert.ToInt32(dr["InvoiceType"]),
                            InvoiceItemCount = Convert.ToInt32(dr["ItemCount"]),
                            InvoiceItemName = Convert.ToString(dr["ItemName"]),
                            RequestUser = Convert.ToString(dr["RequestUser"]),
                            ApproveUser = Convert.ToString(dr["ApproveUser"]),
                            InvoiceStatus = Convert.ToInt32(dr["InvoiceStatus"])

                        });
                }
                catch (Exception e)
                {
                    InvoiceList.Add(
                        new InvoiceModel
                        {
                            InvoiceID = Convert.ToInt32(dr["InvoiceID"]),
                            InvoiceType = Convert.ToInt32(dr["InvoiceType"]),
                            InvoiceItemCount = Convert.ToInt32(dr["ItemCount"]),
                            InvoiceItemName = Convert.ToString(dr["ItemName"]),
                            RequestUser = Convert.ToString(dr["RequestUser"]),
                            ApproveUser = "NEEDS REVIEW",
                            InvoiceStatus = Convert.ToInt32(dr["InvoiceStatus"])
                        });
                }


            }

            return InvoiceList;
        }

        //To view item details with generic list     
        public List<InvoiceModel> GetAllInvoices()
        {
            connection();
            List<InvoiceModel> InvoiceList = new List<InvoiceModel>();


            SqlCommand com = new SqlCommand("GetInvoices", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind InvoiceModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    InvoiceList.Add(

                        new InvoiceModel
                        {
                            InvoiceID = Convert.ToInt32(dr["InvoiceID"]),
                            InvoiceType = Convert.ToInt32(dr["InvoiceType"]),
                            InvoiceItemCount = Convert.ToInt32(dr["ItemCount"]),
                            InvoiceItemName = Convert.ToString(dr["ItemName"]), 
                            RequestUser = Convert.ToString(dr["RequestUser"]),
                            ApproveUser = Convert.ToString(dr["ApproveUser"]),
                            InvoiceStatus = Convert.ToInt32(dr["InvoiceStatus"])

                        });
                } catch(Exception e)
                {
                    InvoiceList.Add(
                        new InvoiceModel
                        {
                            InvoiceID = Convert.ToInt32(dr["InvoiceID"]),
                            InvoiceType = Convert.ToInt32(dr["InvoiceType"]),
                            InvoiceItemCount = Convert.ToInt32(dr["ItemCount"]),
                            InvoiceItemName = Convert.ToString(dr["ItemName"]),
                            RequestUser = Convert.ToString(dr["RequestUser"]),
                            ApproveUser = "NEEDS REVIEW",
                            InvoiceStatus = Convert.ToInt32(dr["InvoiceStatus"])
                        });
                }


            }

            return InvoiceList;
        }

        public List<InvoiceModel> GetAllNewInvoices()
        {
            connection();
            List<InvoiceModel> InvoiceList = new List<InvoiceModel>();


            SqlCommand com = new SqlCommand("GetNewInvoices", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind InvoiceModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    InvoiceList.Add(

                        new InvoiceModel
                        {
                            InvoiceID = Convert.ToInt32(dr["InvoiceID"]),
                            InvoiceType = Convert.ToInt32(dr["InvoiceType"]),
                            InvoiceItemCount = Convert.ToInt32(dr["ItemCount"]),
                            InvoiceItemName = Convert.ToString(dr["ItemName"]),
                            RequestUser = Convert.ToString(dr["RequestUser"]),
                            ApproveUser = Convert.ToString(dr["ApproveUser"]),
                            InvoiceStatus = Convert.ToInt32(dr["InvoiceStatus"])

                        });
                }
                catch (Exception e)
                {
                    InvoiceList.Add(
                        new InvoiceModel
                        {
                            InvoiceID = Convert.ToInt32(dr["InvoiceID"]),
                            InvoiceType = Convert.ToInt32(dr["InvoiceType"]),
                            InvoiceItemCount = Convert.ToInt32(dr["ItemCount"]),
                            InvoiceItemName = Convert.ToString(dr["ItemName"]),
                            RequestUser = Convert.ToString(dr["RequestUser"]),
                            ApproveUser = "NEEDS REVIEW",
                            InvoiceStatus = Convert.ToInt32(dr["InvoiceStatus"])
                        });
                }


            }

            return InvoiceList;
        }

        //To Update status of invoice    
        public bool UpdateInvoiceStauts(InvoiceModel obj, string userId)
        {

            connection();
            SqlCommand com = new SqlCommand("UpdateInvoices2", con);

            int InvoiceID = obj.InvoiceID;
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@InvoiceID", InvoiceID); //integer comparison is breaking
            com.Parameters.AddWithValue("@ApproveUser", userId);
            com.Parameters.AddWithValue("@InvoiceStatus", obj.InvoiceStatus);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                System.Diagnostics.Debug.WriteLine("IT WORKED");
                return true;

            }
            else
            {

                return false;
            }


        }

        public bool UpdateBankAndDKP(InvoiceModel Invoice)
        {
            PartRepository PartRepo = new PartRepository();
            RosterRepository RostRepo = new RosterRepository();
            BankRepository BankRepo = new BankRepository();

            string userId = Invoice.RequestUser;
            int currentDkp = RostRepo.GetAllRoster().Find(x => x.UserName.Equals(userId)).dkp;

            int ItemDKPValue = BankRepo.GetAllBankItems().Find(x => x.Name.Equals(Invoice.InvoiceItemName)).DKPCost;
            int TotalDkpValue = ItemDKPValue * Invoice.InvoiceItemCount;
            BankModel updatedBankItem = BankRepo.GetAllBankItems().Find(x => x.Name.Equals(Invoice.InvoiceItemName));

            int CurrentNumDonations = RostRepo.GetAllRoster().Find(x => x.UserName.Equals(userId)).numDonations;

            PartModel newPart = new PartModel();
            newPart.UserName = userId;

            //1=request 0=donate
            if (Invoice.InvoiceType==0)
            {
                newPart.dkp = currentDkp - TotalDkpValue;
                PartRepo.UpdateDKP(newPart);

                updatedBankItem.Count -= Invoice.InvoiceItemCount;
                BankRepo.UpdateBankItemCount(updatedBankItem);
            }
            else
            {
                newPart.dkp = currentDkp + TotalDkpValue;
                PartRepo.UpdateDKP(newPart);
                RostRepo.UpdateUserDonations(userId, CurrentNumDonations);

                updatedBankItem.Count += Invoice.InvoiceItemCount;
                BankRepo.UpdateBankItemCount(updatedBankItem);
            }
            return true;
        }

        //Used to calculate Invoice ID
        public int GetInvoiceCount()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Invoices";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Data Source=localhost;Initial Catalog=EntitledDB;Integrated Security=True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }

    }
}
