using Capa_Entidad;
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
    public class BD_Kardex : BD_Conexion
    { //cambio peue
        public static bool segurado = false;
        public static bool detsaved = false;
        public void BD_Registrar_Kaxdex(string idKardex, string idProduct, string idProvee)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();

                SqlCommand cmd = new SqlCommand("sp_crear_kardex", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idkardex", idKardex);
                cmd.Parameters.AddWithValue("@idprod", idProduct);
                cmd.Parameters.AddWithValue("@idprovee", idProvee);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                segurado = true;

            }
            catch (Exception Ex)
            {
                segurado = false;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo insertar el kardex" + Ex.Message, "BD kardex BD_Registrar_Kaxdex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void BD_Registrar_Detalle_Kardex(EN_Kardex Kardex)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand Insertar = new SqlCommand("Sp_registrar_detalle_kardex", cn);
                Insertar.CommandTimeout = 20;
                Insertar.CommandType = CommandType.StoredProcedure;

                Insertar.Parameters.AddWithValue("@Id_Krdx", Kardex.IdKardex);
                Insertar.Parameters.AddWithValue("@Item", Kardex.Item);
                Insertar.Parameters.AddWithValue("@Doc_Soport", Kardex.Doc_soporte);
                Insertar.Parameters.AddWithValue("@Det_Operacion", Kardex.Det_operacion);
                Insertar.Parameters.AddWithValue("@Cantidad_In", Kardex.Cantidad_In);
                Insertar.Parameters.AddWithValue("@Precio_Unt_In", Kardex.Precio_Unit_In);
                Insertar.Parameters.AddWithValue("@Costo_Total_In", Kardex.Costo_Total_In);
                Insertar.Parameters.AddWithValue("@Cantidad_Out", Kardex.Cantidad_Out);
                Insertar.Parameters.AddWithValue("@Precio_Unt_Out", Kardex.Precio_Unt_Out);
                Insertar.Parameters.AddWithValue("@Importe_Total_Out", Kardex.Importe_Total_Out);
                Insertar.Parameters.AddWithValue("@Cantidad_Saldo", Kardex.Cantidad_Saldo);
                Insertar.Parameters.AddWithValue("@Promedio", Kardex.Promedio);
                Insertar.Parameters.AddWithValue("@Costo_Total_Saldo", Kardex.Costo_Total_Saldo);

                cn.Open();
                Insertar.ExecuteNonQuery();
                cn.Close();

                detsaved = true;
            }

            catch (Exception Ex)
            {
                detsaved = false;
                if (cn.State == ConnectionState.Open) cn.Close();

                MessageBox.Show("No se pudo registrar el detalle del kardex" + Ex.Message, "BD Detalle kardex BD_Registrar_Detalle_Kardex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool BD_Verificar_Producto_SiTieneKardex(string idprod)
        {
            bool Repuesta = false;
            Int32 getvalue = 0;

            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Sp_Ver_sihay_Kardex";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Prod", idprod);

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

                MessageBox.Show("hay un kardex" + Ex.Message, "Si no kardex BD_Verificar_Producto_SiTieneKardex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return Repuesta;
        }
        public DataTable BD_Buscar_KardexDetalle_porProducto(string idPro)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter DadSql = new SqlDataAdapter("Sp_Buscador_DeKardex_Principal_yDetalle", cn);
                DadSql.SelectCommand.CommandType = CommandType.StoredProcedure;
                DadSql.SelectCommand.Parameters.AddWithValue("@xvalor", idPro);
                DataTable dato = new DataTable();

                DadSql.Fill(dato);
                return dato;

            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();

                    MessageBox.Show("Errror al guardar el detalle del kardex por producto", "BD_Buscar_KardexDetalle_porProducto" + Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }
    }
}
