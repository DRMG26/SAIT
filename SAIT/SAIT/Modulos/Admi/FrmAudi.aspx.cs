using SAIT.Clases;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace SAIT.Modulos.Admi
{
    public partial class FrmAudi : System.Web.UI.Page
    {
        Operaciones Ope = new Operaciones();
        DataTable Usu = new DataTable();
        DataTable tabla = new DataTable();
        string StCondi;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUsu();
                TxtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy"); 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Default.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            StCondi = (TxtFecha.Text != ""? "@Fecha="+TxtFecha.Text: "@Fecha="+ DateTime.Today.ToString("dd/MM/yyyy"));
            StCondi = StCondi + (CmdUsu.SelectedValue != "0" ? (StCondi != "" ? "," : "") + "@Usuario=" + CmdUsu.SelectedValue : "");
            StCondi = StCondi + (CmdTabla.SelectedValue != "" ? (CmdTabla.SelectedValue != "0"? (StCondi != "" ? "," : "") +"@Tabla=" + CmdTabla.SelectedValue:""): "");
            GrdAudi.DataSource = Ope.GridConsSP("CONS_AUDI", "@Operacion=0,"+ StCondi );
            GrdAudi.DataBind();
        }

        protected void GrdAudi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void CargarUsu()
        {
            
            Usu = Ope.GridConsSP("CONS_AUDI", "@Operacion=1");
            CmdUsu.DataSource = Usu;
          //  CmdUsu.DataSourceID = "";
            CmdUsu.DataValueField = "AudUser";
            CmdUsu.DataTextField = "AudUser";
            CmdUsu.DataBind();
            CmdUsu.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            
        }

        protected void CmdTabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Selecttabla(object sender, EventArgs e)
        {
            tabla = Ope.GridConsSP("CONS_AUDI", "@Operacion=2,@Usuario=" + CmdUsu.SelectedValue);
            CmdTabla.DataSource = tabla;
            CmdTabla.DataValueField = "AudTabla";
            CmdTabla.DataTextField = "AudTabla";
            CmdTabla.DataBind();
            CmdTabla.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void Prueba(object sender, EventArgs e)
        {
            tabla = Ope.GridConsSP("CONS_AUDI", "@Operacion=2,@Usuario='" + CmdUsu.SelectedValue + "'");
            CmdTabla.DataSource = tabla;
            CmdTabla.DataValueField = "AudTabla";
            CmdTabla.DataTextField = "AudTabla";
            CmdTabla.DataBind();
            CmdTabla.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
    }
}