using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SAIT.Clases
{
    public class Conexion
    {
        public SqlConnection SqlConnection()
        {
            try
            {
                string StConBd = System.Configuration.ConfigurationManager.AppSettings["CONEXION"];
                //SqlConnection CON = new SqlConnection(ConBd);
                SqlConnection SqlCon = new SqlConnection("Server=LAPTOP-VQ2EMF5I;Database=Proyecto;User Id=SA;Password = SA;");
                SqlCon.Open();
                return SqlCon;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}