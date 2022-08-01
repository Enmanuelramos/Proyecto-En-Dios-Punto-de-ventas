using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
   

namespace Capa_Datos
{
    public class BD_Proveedor : BD_Conexion
    {
        public void BD_Insertar_Proveedor(EN_Proveedor Insert)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();

                SqlCommand Insertar = new SqlCommand("sp_registrar_Proveedor", cn);
                Insertar.CommandTimeout = 20;
                Insertar.CommandType = CommandType.StoredProcedure;

                Insertar.Parameters.AddWithValue("@idproveedor", Insert.Idproveedor);
                Insertar.Parameters.AddWithValue("@nombre", Insert.Nombre);
                Insertar.Parameters.AddWithValue("@direccion", Insert.Direccion);
                Insertar.Parameters.AddWithValue("@telefono", Insert.Telefono);
                Insertar.Parameters.AddWithValue("@rubro", Insert.Rubro);
                Insertar.Parameters.AddWithValue("@ruc", Insert.Ruc);
                Insertar.Parameters.AddWithValue("@correo", Insert.Correo);
                Insertar.Parameters.AddWithValue("@contacto", Insert.Contacto);
                Insertar.Parameters.AddWithValue("@fotologo", Insert.Fotologo);

                cn.Open();
                Insertar.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("se inserto correctamente");
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo insertar Proveedor" + Ex.Message, "BD_Proveedor BD_Insertar_Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public void BD_Modificar_Proveerdor(EN_Proveedor ModPro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand Modificar = new SqlCommand("sp_Modificar_Proveedor", cn);
                Modificar.CommandTimeout = 20;
                Modificar.CommandType = CommandType.StoredProcedure;

                Modificar.Parameters.AddWithValue("@idproveedor", ModPro.Idproveedor); // no me permite Actualizar el id proveedor
                Modificar.Parameters.AddWithValue("@nombre", ModPro.Nombre);
                Modificar.Parameters.AddWithValue("@direccion", ModPro.Direccion);
                Modificar.Parameters.AddWithValue("@telefono", ModPro.Telefono);
                Modificar.Parameters.AddWithValue("@rubro", ModPro.Rubro);
                Modificar.Parameters.AddWithValue("@ruc", ModPro.Ruc);
                Modificar.Parameters.AddWithValue("@correo", ModPro.Correo);
                Modificar.Parameters.AddWithValue("@contacto", ModPro.Contacto);
                Modificar.Parameters.AddWithValue("@fotologo", ModPro.Fotologo);

                cn.Open();
                Modificar.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Se Modifico correctamente");
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo Modifico Proveedor" + Ex.Message, "BD_Proveedor sp_Modificar_Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable BD_Mostrar_Proveerdor()
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter Mostrar_Proveedor = new SqlDataAdapter("sp_Listar_Todos_Proveedores", cn);
                Mostrar_Proveedor.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable Mostrar = new DataTable();
                //cn.Open();
                Mostrar_Proveedor.Fill(Mostrar);
                Mostrar_Proveedor = null; // para liberar espacio 
                return Mostrar;
                // cn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se Puede Mostrar" + Ex.Message, "BD_Proveedor BD_Mostrar_Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable BD_Buscar_Proveerdor(string valor)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter Mostrar_Proveedor = new SqlDataAdapter("sp_buscar_proveedor_porvalor", cn);
                Mostrar_Proveedor.SelectCommand.CommandType = CommandType.StoredProcedure;
                Mostrar_Proveedor.SelectCommand.Parameters.AddWithValue("@valor", valor);
                DataTable Mostrar = new DataTable();
                //cn.Open();
                Mostrar_Proveedor.Fill(Mostrar);
                Mostrar_Proveedor = null; // para liberar espacio 
                return Mostrar;
                // cn.Close();
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se Puede buscar" + Ex.Message, "BD_Proveedor BD_buscar_Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
    }

}
