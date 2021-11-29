using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class D_contacto
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);

        public DataTable D_listado()
        {
            SqlCommand cmd = new SqlCommand("sq_listar", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 
        public DataTable D_buscar(string barra)
        {

            SqlCommand cmd = new SqlCommand("sp_buscar", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@buscar", barra);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void D_Insertar (string nombre, string apellido, string dc, string g, string estado, string tel, string correo, string fecha)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("sp_insertar", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", nombre);
            cmd.Parameters.Add("@Apellido", apellido);
            cmd.Parameters.Add("@Direccion", dc);
            cmd.Parameters.Add("@Genero", g);
            cmd.Parameters.Add("@Estado", estado);
            cmd.Parameters.Add("@telefono", tel);
            cmd.Parameters.Add("@correo", correo);
            cmd.Parameters.Add("@fecha", fecha);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void D_Modificar(string nombre, string apellido, string dc, string g, string estado, string tel, string correo, string fecha, string c)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("sp_modificar", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", nombre);
            cmd.Parameters.Add("@Apellido", apellido);
            cmd.Parameters.Add("@Direccion", dc);
            cmd.Parameters.Add("@Genero", g);
            cmd.Parameters.Add("@Estado", estado);
            cmd.Parameters.Add("@telefono", tel);
            cmd.Parameters.Add("@correo", correo);
            cmd.Parameters.Add("@fecha", fecha);
            cmd.Parameters.Add("@key", c);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public bool D_validar(string tel)
        {
            bool sd;
            conexion.Open();
            string valida = $"select Nombre from registro where telefono = '{tel}'";
            SqlCommand cmd = new SqlCommand(valida, conexion);
            SqlDataReader sql = cmd.ExecuteReader();
            if (sql.Read())
            {
                if (Convert.ToString(sql["Nombre"]) != "" && Convert.ToString(sql["Nombre"])!="null")
                {
                    sd = false;
                }
                else
                {
                    sd = true;
                }
            }
            else
            {
                sd = true;
            }
            conexion.Close();
            return sd;
            
        }
        public void D_Eliminar(string tel)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("sp_eliminar", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eliminar", tel);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }




    }
}
