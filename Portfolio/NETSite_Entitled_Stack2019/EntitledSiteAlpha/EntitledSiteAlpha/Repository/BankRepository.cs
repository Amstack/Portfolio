using EntitledSiteAlpha.Models;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EntitledSiteAlpha.Repository
{
    public class BankRepository
    {
        
    private SqlConnection con;    
    //To Handle connection related activities    
    private void connection()    
    {      
        con = new SqlConnection("Data Source=localhost;Initial Catalog=EntitledDB;Integrated Security=True");    
  
    }

    //To Add Bank item details    
    public bool AddItem(BankModel obj)    
    {    
  
        connection();    
        SqlCommand com = new SqlCommand("AddNewBankDetails", con);    
        com.CommandType = CommandType.StoredProcedure;    
        com.Parameters.AddWithValue("@ItemID", obj.ItemID);    
        com.Parameters.AddWithValue("@ItemName", obj.Name);    
        com.Parameters.AddWithValue("@ItemImageLink", obj.Link);
        com.Parameters.AddWithValue("@ItemCount", obj.Count);
        com.Parameters.AddWithValue("@ItemCostGold", obj.GoldCost);
        com.Parameters.AddWithValue("@ItemCostDKP", obj.DKPCost);

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

    //To view item details with generic list     
    public List<BankModel> GetAllBankItems()    
    {    
        connection();    
        List<BankModel> BankList =new List<BankModel>();    
           
  
        SqlCommand com = new SqlCommand("GetBank", con);    
        com.CommandType = CommandType.StoredProcedure;    
        SqlDataAdapter da = new SqlDataAdapter(com);    
        DataTable dt = new DataTable();    
          
        con.Open();    
        da.Fill(dt);    
        con.Close();    
        //Bind BankModel generic list using dataRow     
        foreach (DataRow dr in dt.Rows)    
        {    
  
            BankList.Add(    
  
                new BankModel {    
                    ItemID = Convert.ToInt32(dr["ItemID"]),    
                    Name = Convert.ToString( dr["ItemName"]),    
                    Count = Convert.ToInt32(dr["ItemCount"]),   
                    Link = Convert.ToString(dr["ItemImageLink"]),
                    GoldCost = Convert.ToInt32(dr["ItemCostGold"]),
                    DKPCost = Convert.ToInt32(dr["ItemCostDKP"])
  
                });    
  
  
        }

            return BankList;
    }
        //To Update item details    
        public bool UpdateBank(BankModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("UpdateBankDetails", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ItemID", obj.ItemID);
            com.Parameters.AddWithValue("@ItemName", obj.Name);
            com.Parameters.AddWithValue("@ItemImageLink", obj.Link);
            com.Parameters.AddWithValue("@ItemCount", obj.Count);
            com.Parameters.AddWithValue("@ItemCostGold", obj.GoldCost);
            com.Parameters.AddWithValue("@ItemCostDKP", obj.DKPCost);

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

        public bool UpdateBankItemCount(BankModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("UpdateBankCount", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ItemID", obj.ItemID);
            com.Parameters.AddWithValue("@ItemCount", obj.Count);

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

        //To delete item details    
        public bool DeleteBankEntry(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("DeleteBankById", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@BankID", Id);

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
    }
}
