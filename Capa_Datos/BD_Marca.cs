using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class BD_Marca : BD_Conexion
    {
        public void BD_Insertar_Marca(string MarIns)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand ConSul = new SqlCommand("sp_addMarca", cn);
                ConSul.CommandTimeout = 20;
                ConSul.CommandType = CommandType.StoredProcedure;
                ConSul.Parameters.AddWithValue("@marca", MarIns);

                cn.Open();
                ConSul.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Se inserto la Marca Correctamente");
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();

                MessageBox.Show(" No Se inserto Correctamente Marca" + Ex.Message, "El error se encuentra BD_Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Editar_Marca(int MarIdm, string MarEdi)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand ConSul = new SqlCommand("sp_Editar_Marca", cn);
                ConSul.CommandTimeout = 20;
                ConSul.CommandType = CommandType.StoredProcedure;
                ConSul.Parameters.AddWithValue("@idmar", MarIdm);
                ConSul.Parameters.AddWithValue("@nom_marca", MarEdi);

                cn.Open();
                ConSul.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Se ha Edito la Marca");
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                MessageBox.Show("No Se ha editado correctamente" + Ex.Message, "BD_Capa_Datos Editar Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Eliminar_Marca(int MarEli)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();

                SqlCommand ConSul = new SqlCommand("sp_eliminar_Marca", cn);
                ConSul.CommandTimeout = 20;
                ConSul.CommandType = CommandType.StoredProcedure;
                ConSul.Parameters.AddWithValue("@idmar", MarEli);

                cn.Open();
                ConSul.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Se Elimino la marca");
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();

                MessageBox.Show("No se elimino la Marca " + Ex.Message, "BD_Capa_Datos Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable Mostrar_Marca()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter ConSul = new SqlDataAdapter("sp_Listar_Todos_Marcas", cn);
                ConSul.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();

                ConSul.Fill(table);
                ConSul = null;
                return table;

            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("error al Listar" + Ex.Message, "Capa datos BD_Mostrar_Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }
    }
}
