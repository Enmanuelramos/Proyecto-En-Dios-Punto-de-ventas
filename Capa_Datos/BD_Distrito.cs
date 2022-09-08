using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class BD_Distrito : BD_Conexion
    {
        public void BD_Insertar_Distrito(string NombDis)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand Insertar = new SqlCommand("sp_addDistrito", cn);
                Insertar.CommandTimeout = 20;
                Insertar.CommandType = CommandType.StoredProcedure;
                Insertar.Parameters.AddWithValue("@distrito", NombDis);

                cn.Open();
                Insertar.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Se registro exitosamente el Distrito");

            }
            catch (Exception Ex)
            {
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se registor Distrito" + Ex.Message, "BD_Distrito Prj_Capa_Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Editar_Distrito(int idDis, string nomdis , string EstDis)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand editar = new SqlCommand("sp_Editar_Distrito", cn);
                editar.CommandTimeout = 20;
                editar.CommandType = CommandType.StoredProcedure;
                editar.Parameters.AddWithValue("@idDis", idDis);
                editar.Parameters.AddWithValue("@nomdis", nomdis);
                editar.Parameters.AddWithValue("@Estado_Distrito", EstDis);
                cn.Open();
                editar.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Se edito correctamente el Distrito");
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se edito el distrito" + Ex.Message, "BD_Distrito BD_Editar_Distrito",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        
        public void BD_Eliminar_Distrito(int idDis)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand eliminar = new SqlCommand("sp_eliminar_distrito", cn);
                eliminar.CommandTimeout = 20;
                eliminar.CommandType = CommandType.StoredProcedure;
                eliminar.Parameters.AddWithValue("@idDis", idDis);

                cn.Open();
                eliminar.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Se ha eliminado correctamente");
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se edito el he eliminado" + Ex.Message, "BD_Distrito BD_Eliminar_Distrito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable Mostrar_Distrito()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter Mostrar = new SqlDataAdapter("sp_Listar_Todos_Distritos", cn);
                Mostrar.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable Listar = new DataTable();
                Mostrar.Fill(Listar);
                return Listar;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se Mostro" + Ex.Message, "BD_Distrito Mostrar_Distrito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            return null;
        }
    }
}
