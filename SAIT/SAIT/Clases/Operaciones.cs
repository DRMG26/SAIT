using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SAIT.Clases
{
    public class Operaciones
    {
        //STparamtreos Ejemplo "@Articulo='233',@Bodega='aaaa'"
        //los parametros se envian segun como se enviarian en SQL pero es ensencia que lleven el @ y para indentificar el valor sera elvalor que se envia despues del =
        public DataTable GridConsSP(string StNomSP, string StParam="")
        {
          
            string[] StEnvio; //Almacena los parametros ya separados por la ,
            string[] StArr; //Almacena el paramtro separado ya lor el =
           
            Conexion Con = new Conexion();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con.SqlConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StNomSP;
                if (StParam != "")
                {
                    StEnvio = StParam.Split(',');
                    for (int i = 0; i < StEnvio.Length; i++)
                    {
                        StArr = StEnvio[i].Split('=');
                        SqlParameter Paramtros = new SqlParameter(StArr[0], StArr[1]);
                        cmd.Parameters.Add(Paramtros);

                    }
                }
                
                SqlDataAdapter dataA = new SqlDataAdapter(cmd);
                dataA.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
            
        }

        // proposito, tras de una consulta de un SP los resultados los almacena en una ARRAY de 2 dimenciones
        public string[][] SelectSP(string StNomSP, string StParam = "")
        {
            DataTable DtDaTa = new DataTable();

            DtDaTa = GridConsSP(StNomSP ,StParam );

            string[][] StArr = new string[DtDaTa.Rows.Count][];

            int InRowIndex = 0;
            foreach (DataRow row in DtDaTa.Rows)
            {
                StArr[InRowIndex] = new string[DtDaTa.Columns.Count];

                int InColumIndex = 0;
                foreach (DataColumn col in DtDaTa.Columns)
                {
                    StArr[InRowIndex][InColumIndex] = Convert.ToString(row[col.ColumnName]);
                    InColumIndex++;
                }
        
                InRowIndex++;
            }
            return StArr;
        }

        //retorna true o false si el SP retorna valores boolenaos
        public bool BoolSp(string StNomSP, string StParam = "")
        {
            bool Resultado=false;
            string[][] StExec = SelectSP(StNomSP, StParam);

            if (StExec[0][0] == "1")
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }

            return Resultado;
        }

            
    }
}