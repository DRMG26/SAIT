﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAIT.Clases;

namespace SAIT
{
    public partial class Login : System.Web.UI.Page
    {
        DatosUsuario dtUsuario = new DatosUsuario();
        Usuario objUsuario;
        string StMensaje;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                objUsuario = dtUsuario.Login(TxtUser.Text.Trim(), Txtpass.Text.Trim());


                if (TxtUser.Text.ToUpper()  == objUsuario.Login.ToUpper() || Txtpass.Text == objUsuario.Clave )
                {
                    StMensaje = @"<script type='text/javascript'>
                            Mensaje('Bienvenido','','success');
                        </script>";
                    Page.RegisterStartupScript("Mensaje", StMensaje);
                    Response.Redirect("http://localhost:49821/Modulos/Admi/FrmMenuAdm");

                }
                else
                {
                    StMensaje = @"<script type='text/javascript'>
                            Mensaje('Usuario y o contrasena incorrectos','','error');
                        </script>";
                    Page.RegisterStartupScript("Mensaje", StMensaje);
                    
                    
                }

            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {
                string script = "alert('favor valide sus credenciales e intente nuevamente');";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

            }
        }

        protected void Btn_Cancelar_click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    } 
}