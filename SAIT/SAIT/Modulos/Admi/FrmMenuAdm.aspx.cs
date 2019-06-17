using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAIT.Clases;

namespace SAIT.Modulos.Admi
{
    public partial class FrmMenuAdm : System.Web.UI.Page
    {
        UrlModuloAdmin UrlAdmin = new UrlModuloAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAudi_Click(object sender, EventArgs e)
        {
            Response.Redirect(UrlAdmin.StrAuditor);
        }

        protected void LBtnPefi_click(object sender, EventArgs e)
        {
            Response.Redirect(UrlAdmin.StrPerfiles);
        }

        protected void LBtnUsu_Click(object sender, EventArgs e)
        {
            Response.Redirect(UrlAdmin.StrUsuarios);
        }
    }
}