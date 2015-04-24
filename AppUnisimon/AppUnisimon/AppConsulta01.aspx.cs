using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace AppUnisimon
{
    public partial class AppConsulta01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //conexion base de datos
            string cadena=@"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc6\documents\visual studio 2012\Projects\AppUnisimon\AppUnisimon\App_Data\aspnet-AppUnisimon-20150423185123.mdf;Initial Catalog=aspnet-AppUnisimon-20150423185123;Integrated Security=True";

            SqlConnection cn=new SqlConnection(cadena);
        cn.Open();
            string sqlCommand="INSERT INTO Usuario (id,nombre,apellido,edad,correo) VALUES "+"(3,'ABUELO','SIMPSON',80,'ABUELO@ASDFA.COM')";
            
            SqlDataAdapter da =new SqlDataAdapter(sqlCommand,cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();
        
        

        
    }
    }
}