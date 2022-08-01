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
    public class BD_Categoria: BD_Conexion
    {
        public void BD_Registrar_Categoria(string ReGrt)
        {
            SqlConnection cn = new SqlConnection(); // esto es un objeto para hacer la conecion 
            try
            {
                cn.ConnectionString = Conectar(); // tenemos el nombre del objeto y ConnectionString Obtiene o establece la cadena que
                                                  // se utiliza para abrir una base de datos de SQL Server y lo inicializamos con el metodo 

                SqlCommand SqlCom = new SqlCommand("sp_registrar_categoria", cn); //SqlCommand es para hacer consulta o llamar los procedimientos 
                // y tiene dos parametros el nombre de la consulta o los precedimiento y la conexion
                SqlCom.CommandTimeout = 20;// 
                SqlCom.CommandType = CommandType.StoredProcedure;
                SqlCom.Parameters.AddWithValue("@nombre", ReGrt);

                cn.Open();
                SqlCom.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("La Categoria se ha registrado exitosamente");
            }
            catch (Exception Ex)
            {
                // Esta sentencia es para si la conexion se queda abierta porque al correr el programa emite un error
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar " + Ex.Message, "Capa datos BD_Registrar_Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public void BD_Editar_Categoria(int idcat, String EdiCat)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand SqlCmd = new SqlCommand("sp_modificar_categoria", cn);
                SqlCmd.CommandTimeout = 20;
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlCmd.Parameters.AddWithValue("@idcat", idcat);
                SqlCmd.Parameters.AddWithValue("@nombre", EdiCat);

                cn.Open();
                SqlCmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("La Categoria se ha editado correctamente");
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("error al editarse" + Ex.Message, "Capa datos BD_Editar_Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public DataTable BD_Mostrar_categoria()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter SqlAda = new SqlDataAdapter("sp_listar_todas_Categorias", cn);
                SqlAda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();

                SqlAda.Fill(table);
                SqlAda = null;
                return table;

            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("error al Mostrar" + Ex.Message, "Capa datos BD_Mostrar_Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
                
        }
        //Prueva
    }
}
