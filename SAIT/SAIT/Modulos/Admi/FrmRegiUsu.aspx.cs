using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAIT.Clases;

namespace SAIT.Modulos.Admi
{
    public partial class FrmRegiUsu : System.Web.UI.Page
    {
        Operaciones Ope = new Operaciones();
        string StCondi;
        string StCampos;
        string StMensaje;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Existe();
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BtnBorrar_Click(object sender, EventArgs e)
        {
            BORRAR();
        }
        //Limpia el formulario
        protected void Limpiar()
        {
            TxtDoc.Text = "";
            TxtNom.Text = "";
            TxtApe.Text = "";
            TxtTel.Text = "";
            TxtEmail.Text = "";
            TxtDir.Text = "";
        }

        //Guarda nuevos Ususario
        protected void Guardar()
        {

            if (TxtDoc.Text.Trim() == "" || TxtNom.Text.Trim() == "" || TxtApe.Text.Trim() == "" )
            {
                StMensaje = @"<script type='text/javascript'>
                            Mensaje('Llenar los campos obligatorios','','info');
                        </script>";
                Page.RegisterStartupScript("Mensaje", StMensaje);
                return;
            }
            StCampos = "@DOC=" + TxtDoc.Text.ToUpper();
            StCampos = StCampos + ",@TIPO_DOC=" + CmdTipDoc.SelectedValue;
            StCampos = StCampos + ",@NOM=" + TxtNom.Text.Trim();
            StCampos = StCampos + ",@APE=0" + TxtApe.Text.Trim();
            StCampos = StCampos + ",@TEL=" + TxtTel.Text.Trim();
            StCampos = StCampos + ",@DIR=" + TxtDir.Text.Trim();
            StCampos = StCampos + ",@EMAIL=" + TxtEmail.Text.Trim();
            StCampos = StCampos + ",@resultado=0";
            StCampos = StCampos + ",@OPERACION=0";
            string[][] StArr = Ope.SelectSP("SP_IUD_USUARIOS", StCampos);
            if (StArr[0][0] == "1")
            {
                StMensaje = @"<script type='text/javascript'>
                            Mensaje('Se ha almacenado la informacion','','success');
                        </script>";
                Page.RegisterStartupScript("Mensaje", StMensaje);

                Limpiar();
                return;
            }
            else
            {

                StMensaje = "Mensaje('ha ocurrido un proplema','" + StArr[0][1] + "','error')";

                Page.RegisterStartupScript("Mensaje", StMensaje);
                return;
            }

        }

        //Verifica si existe el perfil
        protected void Existe()
        {
            if (TxtDoc.Text.Trim() == "")
            {
                return;
            }
            StCampos = "@DOC=" + TxtDoc.Text.ToUpper();
            StCampos = StCampos + ",@OPERACION=1";
            StCampos = StCampos + ",@resultado=0";
            if (Ope.BoolSp("SP_CONS_USU", StCampos))
            {
                StCampos = "@DOC=" + TxtDoc.Text.ToUpper();
                StCampos = StCampos + ",@TIPO_DOC=" + CmdTipDoc.SelectedValue;
                StCampos = StCampos + ",@NOM=" + TxtNom.Text.Trim();
                StCampos = StCampos + ",@APE=0" + TxtApe.Text.Trim();
                StCampos = StCampos + ",@TEL=" + TxtTel.Text.Trim();
                StCampos = StCampos + ",@DIR=" + TxtDir.Text.Trim();
                StCampos = StCampos + ",@EMAIL=" + TxtEmail.Text.Trim();
                StCampos = StCampos + ",@OPERACION=2";
                StCampos = StCampos + ",@resultado=0";
                string[][] StArr = Ope.SelectSP("SP_IUD_USUARIOS", StCampos);
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

        //Busca los perfiles
        protected void Buscar()
        {
            StCampos = "@DOC=" + TxtDoc.Text.ToUpper();
            StCampos = StCampos + ",@OPERACION=0";
            StCampos = StCampos + ",@resultado=0";
            string[][] StArr = Ope.SelectSP("SP_CONS_USU", StCampos);
            if (StArr.Length > 0)
            {
                if (StArr[0][0] != "")
                {
                    CmdTipDoc.SelectedValue = StArr[0][1];
                    TxtDoc.Text = StArr[0][2];
                    TxtNom.Text = StArr[0][3];
                    TxtApe.Text = StArr[0][4];
                    TxtTel.Text = StArr[0][5];
                    TxtEmail.Text = StArr[0][6];
                    TxtDir.Text = StArr[0][7];

                }
            }
        }

        protected void BORRAR()
        {

            StCampos = "@DOC=" + TxtDoc.Text.ToUpper();
            StCampos = StCampos + ",@OPERACION=1";
            StCampos = StCampos + ",@resultado=0";
            if (Ope.BoolSp("SP_CONS_USU", StCampos))
            {
                StCampos = "@DOC=" + TxtDoc.Text.ToUpper();
                StCampos = StCampos + ",@OPERACION=1";
                StCampos = StCampos + ",@resultado=0";
                string[][] StArr = Ope.SelectSP("SP_IUD_USUARIOS", StCampos);
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

        protected void TxtDoc_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}