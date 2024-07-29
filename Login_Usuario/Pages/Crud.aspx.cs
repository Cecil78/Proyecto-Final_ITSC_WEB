using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Usuario.Pages
{
    public partial class Crud : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public static string sID = "-1";
        public static string sOpc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Aquí se obtiene el ID
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    sID = Request.QueryString["id"].ToString();
                    CargarDatos();
                    TxtFN.TextMode = TextBoxMode.DateTime;

                }
                }
                if (Request.QueryString["op"] != null)
                {
                    sOpc = Request.QueryString["op"].ToString();

                    switch (sOpc)
                    {
                        case "C":
                            this.lblTitulo.Text = "Ingresar nuevo Usuario";
                            this.BtnCrear.Visible = true;
                            break;
                        case "L":
                            this.lblTitulo.Text = "Consulta de Usuario";
                            break;
                        case "A":
                            this.lblTitulo.Text = "Modificar Usuario";
                            this.BtnActualizar.Visible = true;
                            break;
                        case "E":
                            this.lblTitulo.Text = "Eliminar Usuario";
                            this.BtnEliminar.Visible = true;
                            break;
                    }

                }
            }
        void CargarDatos()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_leer", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            TxtNombre.Text = row[3].ToString();
            TxtEdad.Text = row[4].ToString();
            TxtEmail.Text = row[5].ToString();
            DateTime date = (DateTime)row[6];
            TxtFN.Text = date.ToString("dd/MM/yyyy");
            con.Close();
        }
        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_crear ", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
            cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = TxtEdad.Text;
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = TxtEmail.Text;
            cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = TxtFN.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("IndexCrud.aspx");

        }
        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_actualizar", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
            cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = TxtEdad.Text;
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = TxtEmail.Text;
            cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = TxtFN.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("IndexCrud.aspx");
        }
        protected void BtnEliminar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("sp_eliminar", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("IndexCrud.aspx");
        }
        protected void BtnVolver_Click(object sender, EventArgs e)
        {

            Response.Redirect("IndexCrud.aspx");
        }
    }
    

   



    

       
    }

