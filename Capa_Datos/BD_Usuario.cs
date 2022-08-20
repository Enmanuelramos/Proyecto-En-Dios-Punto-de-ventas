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
    public class BD_Usuario : BD_Conexion
    {
        public bool BD_Login(string UsuAri, string UsuCOn)
        {
            bool Respuesta = false;
            Int32 getvalue = 0;

            SqlConnection cn = new SqlConnection();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cn.ConnectionString = Conectar();

                cmd.CommandText = "Sp_Login";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", UsuAri);
                cmd.Parameters.AddWithValue("@Contraseña", UsuCOn);

                cn.Open();
                getvalue = Convert.ToInt32(cmd.ExecuteScalar());

                if (getvalue > 0)
                {
                    Respuesta = true;
                }
                else
                {
                    Respuesta = false;
                }


                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();

            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al registrarse: " + Ex.Message, "Capa Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Respuesta = false;
            }

            return Respuesta;
        }

        public DataTable BD_BuscarUsuario(string NomUsu)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Usuario_Login", cn);
                //da.SelectCommand.CommandText = ;
                //da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Usuario", NomUsu);
                DataTable Data = new DataTable();

                da.Fill(Data);
                da = null;
                return Data;

            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se Puede Mostrar" + Ex.Message, "BD_Usuario BD_BuscarUsuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public void BD_NombreUsuario(string ReGrt)
        {
            SqlConnection cn = new SqlConnection(); // esto es un objeto para hacer la conecion 
            try
            {
                cn.ConnectionString = Conectar(); // tenemos el nombre del objeto y ConnectionString Obtiene o establece la cadena que
                                                  // se utiliza para abrir una base de datos de SQL Server y lo inicializamos con el metodo 

                SqlCommand SqlCom = new SqlCommand("Sp_buscar_Nombre_Usuario", cn); //SqlCommand es para hacer consulta o llamar los procedimientos 
                // y tiene dos parametros el nombre de la consulta o los precedimiento y la conexion
                SqlCom.CommandTimeout = 20;// 
                SqlCom.CommandType = CommandType.StoredProcedure;
                SqlCom.Parameters.AddWithValue("@nombre", ReGrt);

                cn.Open();
                SqlCom.ExecuteNonQuery();
                cn.Close();

                //MessageBox.Show("La Categoria se ha registrado exitosamente");
            }
            catch (Exception Ex)
            {
                // Esta sentencia es para si la conexion se queda abierta porque al correr el programa emite un error
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show(Ex.Message);
                //MessageBox.Show("Error al guardar " + Ex.Message, "Capa datos BD_Registrar_Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
