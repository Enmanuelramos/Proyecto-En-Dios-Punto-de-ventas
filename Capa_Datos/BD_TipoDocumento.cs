using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class BD_TipoDocumento : BD_Conexion
    {
        public static string BD_Numero_ID(int Id_Tipo)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar2(); // nota los metodos estaticos solo se puede relacionar con otras estaticos 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Sp_Listado_Tipo";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);

                string NroDoc;

                cn.Open();
                NroDoc = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();

                return NroDoc;
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();

                MessageBox.Show("Error" + Ex.Message, "Numero del kardex BD_Numero_ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Dispose();
                cn = null;
                return null;
            }
        }

        public static void BD_Actualizar_Tipo_Document(int Id_Tipo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Sp_Actualiza_Tipo_Doc";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                cmd.Dispose();
                //cmd = null;
                //cn = null;

            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                // cmd.Dispose();
                //cn = null;
                MessageBox.Show("Error" + Ex.Message, "Actualizar BD_Actualizar_Tipo_Document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void BD_Actualizar_Tipo_Document_CorelativoProducto(int Id_Tipo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Sp_Actualiza_Tipo_Prodcto";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                cmd.Dispose();
                //cmd = null;
                //cn = null;

            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                // cmd.Dispose();
                //cn = null;
                MessageBox.Show("Error" + Ex.Message, "Actualizar tipode documento correlativo BD_Actualizar_Tipo_Document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void BD_Actualizar_tipo_de_Cambio(int Id_Tipo, double TIpCam)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Sp_Editar_Tipo_Cambio";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idtipo", Id_Tipo);
                cmd.Parameters.AddWithValue("@numero", TIpCam);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                cmd.Dispose();
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                MessageBox.Show("Error al cambiar tipo de cambio" + Ex.Message, "Actualizar BD_Actualizar_Tipo_Document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static double BD_Leer_Tipo_Cambio(int Id_Tipo)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar2(); // nota los metodos estaticos solo se puede relacionar con otras estaticos 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Sp_Listado_TipoCambio";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);

                double TipoCAmbio;

                cn.Open();
                TipoCAmbio = Convert.ToDouble(cmd.ExecuteScalar());
                cn.Close();

                return TipoCAmbio;
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();

                MessageBox.Show("Error" + Ex.Message, "Numero del kardex BD_Numero_ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Dispose();
                cn = null;
                return 0;
            }
        }
    }
}
