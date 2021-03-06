﻿




using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web.Services.Protocols;


namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.

    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debuggin
  

    public class Service1 : IService1
    {
       

        int IService1.Addgame(string name)
        {
            string sqls = "INSERT INTO tblGame (gNAME) VALUES(@0);";

            SqlCommand comm = new SqlCommand(sqls);

            comm.Parameters.AddWithValue("@0", name);


            return Enq(comm);
        }

        Object[] IService1.Getkills(int Gameid)
        {
            string sqlStatement = "SELECT sKILL FROM tblSchedule WHERE gID=@0";

            SqlCommand comm = new SqlCommand(sqlStatement);

            comm.Parameters.AddWithValue("@0", Gameid);

            DataSet ds = Eq(comm);

            string[] result = null;

            if (!(ds.Tables.Count == 0) && !(ds.Tables[0].Rows.Count == 0))
            {
                string[] temp = new string[ds.Tables[0].Rows.Count];
                for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                {
                    temp[k] = ds.Tables[0].Rows[k][0].ToString();
                }
                result = temp;
            }


            return result;


        }



        Object[] IService1.Getdeaths(int Gameid)
        {
            string sqlStatement = "SELECT sDEATH FROM tblSchedule WHERE gID=@0";

            SqlCommand comm = new SqlCommand(sqlStatement);

            comm.Parameters.AddWithValue("@0", Gameid);

            DataSet ds = Eq(comm);

            string[] result = null;

            if (!(ds.Tables.Count == 0) && !(ds.Tables[0].Rows.Count == 0))
            {
                string[] temp = new string[ds.Tables[0].Rows.Count];
                for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                {
                    temp[k] = ds.Tables[0].Rows[k][0].ToString();
                }
                result = temp;
            }


            return result;
        }



        int IService1.Insertdata(int Gameid, int Kills, int Death)
        {
            string sqlStatement = "INSERT INTO tblSchedule (gID,  sKILL, sDEATH) VALUES(@0,@1,@2);";

            SqlCommand comm = new SqlCommand(sqlStatement);

            comm.Parameters.AddWithValue("@0", Gameid);
           
            comm.Parameters.AddWithValue("@1", Kills);
            comm.Parameters.AddWithValue("@2", Death);


            return Enq(comm);
         
        }

           

        int IService1.GetIgn()
        {
            throw new NotImplementedException();
        }

        int IService1.GetSteam()
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        [SoapHeader("getgames")]
        Object[] IService1.Getgames()
        {
            

            DataSet ds = Eq(new SqlCommand("SELECT  gNAME FROM tblGame"));

            string[] result = null;

            if (!(ds.Tables.Count == 0) && !(ds.Tables[0].Rows.Count == 0))
            {
                string[] temp = new string[ds.Tables[0].Rows.Count];
                for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                {
                    temp[k] = ds.Tables[0].Rows[k][0].ToString();
                }
                result = temp;
            }


            return result;
        }



        private static SqlDataReader reader;
        private static String ConnectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        private static DataSet tempset;
        private static SqlConnection conn = new SqlConnection(ConnectionString);

        
        public static DataSet Eq(SqlCommand comm)
        {
            try
            {
                comm.Connection = conn;

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                tempset = new DataSet();
                adapter.Fill(tempset);

            }
            catch (Exception e)
            { }


            return tempset;
        }


        public static int Enq(SqlCommand comm)
        {
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.ExecuteNonQuery();
                comm.Dispose();
            }
            catch (Exception e)
            {

                return 0;

            }
            finally
            {
                if (!(conn == null))
                    conn.Close();
            }

            return 1;
        }
    
        public static String gcs()
        {
            return ConnectionString;
        }
        
        public static void scs(String newString)
        {
            ConnectionString = newString;
        }

        object[] IService1.Getgamesid()
        {
            DataSet ds = Eq(new SqlCommand("SELECT  gAppid FROM tblGame"));

            string[] result = null;

            if (!(ds.Tables.Count == 0) && !(ds.Tables[0].Rows.Count == 0))
            {
                string[] temp = new string[ds.Tables[0].Rows.Count];
                for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                {
                    temp[k] = ds.Tables[0].Rows[k][0].ToString();
                }
                result = temp;
            }


            return result;
        }
    }


}
