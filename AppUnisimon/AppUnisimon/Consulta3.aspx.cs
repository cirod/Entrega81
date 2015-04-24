using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace AppUnisimon
{
    public partial class Consulta3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            //conexion base de datos

            string n1, ap1, email;
            int edad;
            n1 = txtNombre.Text;
            ap1 = txtApellido.Text;
            edad = int.Parse(txtEdad.Text);
            email = txtEmail.Text;

            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc6\documents\visual studio 2012\Projects\AppUnisimon\AppUnisimon\App_Data\aspnet-AppUnisimon-20150423185123.mdf;Initial Catalog=aspnet-AppUnisimon-20150423185123;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();
            string sqlCommand = "INSERT INTO usuario(nombre,apellido,edad,correo) VALUES" + "('" + n1 + "','" + ap1 + "'," + edad + ",'" + email + "')";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            //  DataTable data = new DataTable();


            //   int record = da.Fill(data);
            // GridView1.DataSource = data;
            // GridView1.DataBind();

            cn.Close();
        }
    }
}