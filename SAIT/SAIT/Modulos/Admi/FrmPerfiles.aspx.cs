﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Services;
using System.Web.UI.WebControls;
using SAIT.Clases;


namespace SAIT.Modulos.Admi
{
    public partial class FrmPerfiles : System.Web.UI.Page
    {
        Operaciones Ope = new Operaciones();
        string StCondi;
        string StCampos;
        string StMensaje;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RadioButton1.Checked = true;
            }

            if (TxtCod.Text != "")
            {
               
            }
        }
        
        //Limpia el formulario
        protected void Limpiar()
        {
            TxtCod.Text = "";
            TxtContra.Text = "";
            TxtContra2.Text = "";
            TxtDoc.Text = "";
            RadioButton1.Checked = true;
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Guarda nuevos perfiles
        protected void Guardar()
        {

            if (TxtCod.Text == "" || TxtContra.Text == "")
            {
                StMensaje = "Mensaje('Llenar todos los campos','Datos Incompletos','info');";
                Page.RegisterStartupScript("Mensaje", StMensaje);
                return;

            }
            StCampos = "@COD_DOC=" + TxtCod.Text;
            StCampos = StCampos + ",@CONTRA=" + TxtContra.Text;
            StCampos = StCampos + ",@DOCU=" + (TxtDoc.Text == "" ? TxtDoc.Text : "NULL");
            StCampos = StCampos + ",@OPERACION=0";
            StCampos = StCampos + ",@TIPO=" + (RadioButton1.Checked == true ? "0" : (RadioButton2.Checked == true ? "1" : (RadioButton3.Checked == true ? "2" : "2")));
            StCampos = StCampos + ",@resultado=0";
            string[][] StArr = Ope.SelectSP("SP_IUD_PERFILES", StCampos);
            if (StArr[0][0] == "1")
            {
                StMensaje = @"<script type='text/javascript'>
                            Mensaje('Se ha almacenado la informacion','','success');
                        </script>";
                Page.RegisterStartupScript("Mensaje", StMensaje);

                Limpiar();
                return;
            }
            else {

                StMensaje = "Mensaje('ha ocurrido un proplema','" + StArr[0][1] + "','error')";

                Page.RegisterStartupScript("Mensaje", StMensaje);
                return;
        }

        }

        //Verifica si existe el perfil
        protected void Existe()
        {
            StCampos = "@COD_DOC=" + TxtCod.Text;
            StCampos = StCampos + ",@OPERACION=1";
            StCampos = StCampos + ",@resultado=0";
            if (Ope.BoolSp("SP_CONS_PERFIL", StCampos))
            {
                StCampos = "@COD_DOC=" + TxtCod.Text;
                StCampos = StCampos + ",@CONTRA=" + TxtContra.Text;
                StCampos = StCampos + ",@DOCU=" + (TxtDoc.Text == "" ? TxtDoc.Text : "NULL");
                StCampos = StCampos + ",@OPERACION=2";
                StCampos = StCampos + ",@TIPO=" + (RadioButton1.Checked == true ? "0" : (RadioButton2.Checked == true ? "1" : (RadioButton3.Checked == true ? "2" : "2")));
                StCampos = StCampos + ",@resultado=0";
                string[][] StArr = Ope.SelectSP("SP_IUD_PERFILES", StCampos);
                if (StArr[0][0] == "1")
                {
                    StMensaje = @"<script type='text/javascript'>
                            Mensaje('Se han actualizado los datos','','success');
                        </script>";

                    Page.RegisterStartupScript("Mensaje", StMensaje);
                    Limpiar();
                    return;
                }
                else
                {
                    StMensaje = @"<script type='text/javascript'>
                            Mensaje('ha ocurrido un proplema','" + StArr[0][1] + "','error'); </script>";

                    Page.RegisterStartupScript("Mensaje", StMensaje);
                    return;
                }
            }
            else
            {
                Guardar();
                return;
            }
        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Existe();
            
        }

        protected void TxtCod_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        //Busca los perfiles
        protected void Buscar()
        {
            StCampos = "@COD_DOC=" + TxtCod.Text;
            StCampos = StCampos + ",@OPERACION=0";
            StCampos = StCampos + ",@resultado=0";
            string[][] StArr = Ope.SelectSP("SP_CONS_PERFIL", StCampos);
            if (StArr.Length >0)
            {
                if (StArr[0][0] != "")
                {
                    TxtContra.Text = StArr[0][1];
                    TxtDoc.Text = StArr[0][2];
                    switch (StArr[0][3])
                    {
                        case "0":
                            RadioButton2.Checked = false;
                            RadioButton3.Checked = false;
                            RadioButton1.Checked = true;
                            break;
                        case "1":
                            RadioButton3.Checked = false;
                            RadioButton1.Checked = false;
                            RadioButton2.Checked = true;
                            break;
                        case "2":
                            RadioButton1.Checked = false;
                            RadioButton2.Checked = false;
                            RadioButton3.Checked = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        protected void BORRAR()
        {
            
            StCampos = "@COD_DOC=" + TxtCod.Text;
            StCampos = StCampos + ",@OPERACION=1";
            StCampos = StCampos + ",@resultado=0";
            if (Ope.BoolSp("SP_CONS_PERFIL", StCampos))
            {
                StCampos = "@COD_DOC=" + TxtCod.Text;
                StCampos = StCampos + ",@OPERACION=1";
                StCampos = StCampos + ",@resultado=0";
                string[][] StArr = Ope.SelectSP("SP_IUD_PERFILES", StCampos);
                if (StArr[0][0] == "1")
                {
                    StMensaje = "Mensaje('Se ha eliminado el perfil','','success');";
                    ClientScript.RegisterStartupScript(this.GetType(), "prueba", StMensaje, true);
                    Page.RegisterStartupScript("Mensaje", StMensaje);
                    Limpiar();
                    return;
                }
                else
                {
                    StMensaje = @"<script type='text/javascript'>
                            Mensaje('ha ocurrido un proplema','" + StArr[0][1] + "','error'); </script>";

                    Page.RegisterStartupScript("Mensaje", StMensaje);
                    return;
                }
            }
            else
            {
                StMensaje = @"<script type='text/javascript'>
                            Mensaje('El perfil no Existe','','info');
                        </script>";

                Page.RegisterStartupScript("Mensaje", StMensaje);
                return;
            }

        }

        protected void BtnBorrar_Click(object sender, EventArgs e)
        {
            BORRAR();
        }

        
    }
}