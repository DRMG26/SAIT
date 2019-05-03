using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAIT.Modulos.Admi
{
    public partial class FrmMenuAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAudi_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAudi.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Default.aspx");
        }

        protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Default.aspx");
        }

        protected void btnPrueba_Click(object sender, EventArgs e)
        {
             Response.Redirect("Default.aspx");
        }
    }
}