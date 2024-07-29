using System;

namespace Login_Usuario
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioentrado"] != null)
            {
                string usuarioentrado = Session["usuarioentrado"].ToString();
                lblBienvenida.Text = "Bienvenido/a " + usuarioentrado;
            }
            else
            {
                Response.Redirect("LoginUsuario.aspx");
            }
        }
        protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("usuarioentrado");
            Response.Redirect("LoginUsuario.aspx");
        }
    }
}