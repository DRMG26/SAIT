using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAIT.Clases;

namespace SAIT.Modulos.Administrativo
{
    public partial class MtrAdmin : System.Web.UI.MasterPage
    {
        UrlModuloAdmin UrlAdmin = new UrlModuloAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
               
            }

        }

        protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Default.aspx");
        }

        protected void LBtnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect(UrlAdmin.StMenu );
        }
        protected void LBtnAudi_Click(object sender, EventArgs e)
        {
            Response.Redirect(UrlAdmin.StrAuditor );
        }
        protected void LBtnPerfi_Click(object sender, EventArgs e)
        {
            Response.Redirect(UrlAdmin.StrPerfiles);
        }

    }
}