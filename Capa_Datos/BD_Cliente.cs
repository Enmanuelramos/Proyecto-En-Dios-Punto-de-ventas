using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Datos
{
    public class BD_Cliente: BD_Conexion
    {
       public bool BD_Verificar_Numero_CLiente_DNI(string idpCli)
        {
            bool Repuesta = false;
            Int32 getvalue = 0;

            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Validar_NroDNI";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", idpCli);

                cn.Open();
                getvalue = Convert.ToInt32(cmd.ExecuteScalar());// se usa escalar por que devuelve un valor 0 o 1 
                                                                // y necesito saber si el producto tiene kardex. es por ejemplo si hay un kardex te manda un (1) y si no existe me manda un (0)

                if (getvalue > 0)
                {
                    Repuesta = true;
                }
                else
                {
                    Repuesta = false;
                }

                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                
                MessageBox.Show("hay un DNI en cliente" + Ex.Message, "no hay un DNI en Cliente,BD_Verificar_Numero_CLiente_DNI,sp_Validar_NroDNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return Repuesta;
        }
        public static bool saved = false;
        public void BD_Insetar_Cliente(EN_Clientes V)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand Insetar = new SqlCommand("Sp_Registrar_Cliente", cn);
                Insetar.CommandTimeout = 20;
                Insetar.CommandType = CommandType.StoredProcedure;

                Insetar.Parameters.AddWithValue("@idcliente ", V.Idcliente);
                Insetar.Parameters.AddWithValue("@razonsocial", V.Razonsocial);
                Insetar.Parameters.AddWithValue("@dni",V.Dni);
                Insetar.Parameters.AddWithValue("@direccion",V.Direccion);
                Insetar.Parameters.AddWithValue("@telefono", V.Telefono);
                Insetar.Parameters.AddWithValue("@email",V.Emiel);
                Insetar.Parameters.AddWithValue("@idDis",V.IdDis);
                Insetar.Parameters.AddWithValue("@fechaAniver", V.FechaAniver);
                Insetar.Parameters.AddWithValue("@contacto",V.Contacto);
                Insetar.Parameters.AddWithValue("@limiteCred",V.LimiteCred);

                cn.Open();
                Insetar.ExecuteNonQuery();
                cn.Close();

                saved = true;
            }
            catch (Exception Ex)
            {
                saved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo insertar los datos" + Ex.Message, "BD_Insertar_Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static bool Edito = false;
        public void BD_ModificarCliente(EN_Clientes V)
        {
            SqlConnection cn = new SqlConnection();
            
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Sp_Modificar_Cliente";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idcliente ", V.Idcliente);
                cmd.Parameters.AddWithValue("@razonsocial", V.Razonsocial);
                cmd.Parameters.AddWithValue("@dni", V.Dni);
                cmd.Parameters.AddWithValue("@direccion", V.Direccion);
                cmd.Parameters.AddWithValue("@telefono", V.Telefono);
                cmd.Parameters.AddWithValue("@email", V.Emiel);
                cmd.Parameters.AddWithValue("@idDis", V.IdDis);
                cmd.Parameters.AddWithValue("@fechaAniver", V.FechaAniver);
                cmd.Parameters.AddWithValue("@contacto", V.Contacto);
                cmd.Parameters.AddWithValue("@limiteCred", V.LimiteCred);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Edito = true;
            }
            catch (Exception EX)
            {
                Edito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo insertar el cliente" + EX.Message, "BD_ModificarCliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public DataTable BD_Listar_Clientes(string v)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter Dat = new SqlDataAdapter("sp_Listar_Todos_Clientes",cn);
                Dat.SelectCommand.CommandType = CommandType.StoredProcedure;
                Dat.SelectCommand.Parameters.AddWithValue("@estado",v);
                DataTable Dato = new DataTable();

                Dat.Fill(Dato);
                return Dato;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }
            return null;
        }
        public DataTable BD_Bucar_Los_Cliente(string valor, string Estado)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter Dat = new SqlDataAdapter("Sp_Buscar_Cliente_porValor",cn);
               // Dat.SelectCommand.CommandText = "Sp_Buscar_Cliente_porValor"; //error en la busqueda del cliente 
                //Dat.SelectCommand.Connection = cn;
                Dat.SelectCommand.CommandType = CommandType.StoredProcedure;
                Dat.SelectCommand.Parameters.AddWithValue("@Valor", valor);
                Dat.SelectCommand.Parameters.AddWithValue("@estado", Estado);
                DataTable Dato = new DataTable();

                Dat.Fill(Dato);
               // Dat = null;
                return Dato;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }
            return null;
        }
        public void BD_DarDeBaja_Cliente(string V)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand Eliminar = new SqlCommand("Sp_DarBajar_Cliente", cn);
                Eliminar.CommandTimeout = 20;
                Eliminar.CommandType = CommandType.StoredProcedure;
                Eliminar.Parameters.AddWithValue("@idcliente ", V);
              
                cn.Open();
                Eliminar.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo Dar debaja" + Ex.Message, "BD_Modificar_Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static bool Elimino = false;
        public void BD_Eliminar_Cliente(string V)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand Eliminar = new SqlCommand("Sp_Eliminar_Cliente", cn);
                Eliminar.CommandTimeout = 20;
                Eliminar.CommandType = CommandType.StoredProcedure;
                Eliminar.Parameters.AddWithValue("@idcliente ", V);

                cn.Open();
                Eliminar.ExecuteNonQuery();
                cn.Close();

                Elimino = true;
            }
            catch (Exception Ex)
            {
                Elimino = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo Eliminar los datos" + Ex.Message, "BD_Modificar_Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
     }
}
