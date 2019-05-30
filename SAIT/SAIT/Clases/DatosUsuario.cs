using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace SAIT.Clases
{
    public class DatosUsuario
    {
        string _strCadenaConexion;

        public string CadenaConexion
        {
            get
            {
                if (_strCadenaConexion == null)
                {
                    _strCadenaConexion = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                }
                return _strCadenaConexion;
            }

            set
            {
                _strCadenaConexion = value;
            }
        }


        public Usuario Login(string _strUsuario, string _strClave)
        {
            Operaciones Ope = new Operaciones();
            

            Usuario objUsuario = new Usuario();

            string StCampos;

            StCampos = "@COD_USU=" + _strUsuario;
            StCampos = StCampos + ",@PASSWORD="+ _strClave;
            StCampos = StCampos + ",@Operacion=0";
            string[][] StArr = Ope.SelectSP("LOGIN_USUS", StCampos);
            if (StArr[0][0] != "")
            {
                objUsuario = new Usuario(int.Parse(StArr[0][0]), StArr[0][1], StArr[0][2], StArr[0][3], StArr[0][4],true,true);
            }
               

            //using (SqlConnection con = new SqlConnection(CadenaConexion))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("IngresoLogin", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@USUARIO", _strUsuario);
            //    cmd.Parameters.AddWithValue("@CLAVE", _strClave);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr != null && dr.HasRows)
            //    {
            //        dr.Read();
            //        objUsuario = new Usuario((int)dr["CodUsu"],
            //            (string)dr["Usuario"], (string)dr["Clave"],
            //            (string)dr["nombre"], (string)dr["apellido"], (Boolean)dr["SuperUsuario"],
            //            (Boolean)dr["IndicadorActivo"]);

            //    }
            //}
            return objUsuario;
        }
    }
}