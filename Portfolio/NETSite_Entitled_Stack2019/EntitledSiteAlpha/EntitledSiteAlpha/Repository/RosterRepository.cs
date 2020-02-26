using EntitledSiteAlpha.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EntitledSiteAlpha.Repository
{
    public class RosterRepository
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            con = new SqlConnection("Data Source=localhost;Initial Catalog=EntitledDB;Integrated Security=True");

        }

        //To view roster details with generic list     
        public List<RosterModel> GetAllRoster()
        {
            connection();
            List<RosterModel> RosterList = new List<RosterModel>();


            SqlCommand com = new SqlCommand("GetRoster", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind RosterModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    RosterList.Add(

                        new RosterModel
                        {
                            UserName = Convert.ToString(dr["UserName"]),
                            dkp = Convert.ToInt32(dr["dkp"]),
                            numDonations = Convert.ToInt32(dr["numDonations"])

                        });
                } catch (Exception e)
                {
                    RosterList.Add(
                        new RosterModel
                        {
                            UserName = Convert.ToString(dr["UserName"]),
                            dkp = 0,
                            numDonations = 0
                        }); ;
                }

            }

            return RosterList;
        }

        public bool UpdateUserDonations(string userId, int currentDon)
        {
            connection();

            SqlCommand com = new SqlCommand("UpdateUserDonations", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UserName",userId);
            com.Parameters.AddWithValue("@NumDon",currentDon+1);

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
