using EntitledSiteAlpha.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EntitledSiteAlpha.Repository
{
    public class PartRepository
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            con = new SqlConnection("Data Source=localhost;Initial Catalog=EntitledDB;Integrated Security=True");

        }

        //Do participation form 
        public bool UpdateDKP(PartModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("PartForm", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@dkp", obj.dkp);
            com.Parameters.AddWithValue("@UserName", obj.UserName);

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
