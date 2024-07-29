using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Login_Usuario.Pages
{
    public partial class IndexCrud : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        void CargarTabla()
        {
            SqlCommand cmd = new SqlCommand("sp_cargar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grusuarios.DataSource = dt;
            grusuarios.DataBind();
            con.Close();
        }
        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/CRUD.aspx?op=C");
        }

        protected void BtnLeer_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectdrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectdrow.Cells[0].Text;
            Response.Redirect("~/Pages/CRUD.aspx? id=" + id + "&op=L");
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectdrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectdrow.Cells[0].Text;
            Response.Redirect("~/Pages/CRUD.aspx? id=" + id + "&op=A");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectdrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectdrow.Cells[0].Text;
            Response.Redirect("~/Pages/CRUD.aspx? id=" + id + "&op=E");


        }






    }
}

