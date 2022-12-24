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
    public class BD_Productos : BD_Conexion
    {
        public static bool seguardo = false;
        public static bool edito = false;
        public void BD_Insertar_Productos(EN_Productos insert)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();

                SqlCommand Insertar = new SqlCommand("sp_Insertar_Productos", cn);
                Insertar.CommandTimeout = 20;
                Insertar.CommandType = CommandType.StoredProcedure;

                Insertar.Parameters.AddWithValue("@idpro", insert.Idproducto);
                Insertar.Parameters.AddWithValue("@idprove", insert.IdProveedor);
                Insertar.Parameters.AddWithValue("@descripcion", insert.Descripcion);
                Insertar.Parameters.AddWithValue("@frank", insert.Frank);
                Insertar.Parameters.AddWithValue("@Pre_compraSol", insert.Pre_compraSol);
                
                Insertar.Parameters.AddWithValue("@StockActual", insert.StockActual);
                Insertar.Parameters.AddWithValue("@idCat", insert.IdCat);
                Insertar.Parameters.AddWithValue("@idMar", insert.IdMar);
                Insertar.Parameters.AddWithValue("@Foto", insert.Foto);
                Insertar.Parameters.AddWithValue("@Pre_Venta_Menor", insert.Pre_Venta_Menor);
                Insertar.Parameters.AddWithValue("@Pre_Venta_Mayor", insert.Pre_Venta_Mayor);
                
                Insertar.Parameters.AddWithValue("@UndMdida", insert.UndMdida);
                
                Insertar.Parameters.AddWithValue("@Utilidad", insert.Utilidad);
                Insertar.Parameters.AddWithValue("@TipoProd ", insert.TipoProd);
                Insertar.Parameters.AddWithValue("@ValorporProd ", insert.ValorporProd);


                cn.Open();
                Insertar.ExecuteNonQuery();
                cn.Close();

                seguardo = true;
            }
            catch (Exception EX)
            {
                seguardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo insertar Producto" + EX.Message, "BD_Producto BD_Insertar_Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show(""+EX);
            }
        }
        public DataTable Mostrar_Productos()
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter Mostrar = new SqlDataAdapter("sp_cargar_Todos_Productos", cn);
                Mostrar.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable datos = new DataTable();

                Mostrar.Fill(datos);
                Mostrar = null;
                return datos;

            }
            catch (Exception Ex)
            {

                MessageBox.Show("No se Puede Mostrar" + Ex.Message, "BD_Productos BD_Mostrar_Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable BD_Buscar_Productos(string v)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter buscar = new SqlDataAdapter("Sp_buscador_Productos", cn);
                buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
                buscar.SelectCommand.Parameters.AddWithValue("@valor", v);
                DataTable data = new DataTable();

                buscar.Fill(data);
                buscar = null;
                return data;
            }
            catch (Exception Ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Open();
                }
                MessageBox.Show("No se Puede buscar" + Ex.Message, "BD_Producto BD_buscar_Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public void BD_Modificar_Productos(EN_Productos ModPro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand Modificar = new SqlCommand("Sp_Editar_Producto", cn);
                Modificar.CommandTimeout = 20;
                Modificar.CommandType = CommandType.StoredProcedure;

                Modificar.Parameters.AddWithValue("@idpro", ModPro.Idproducto);
                Modificar.Parameters.AddWithValue("@idprove", ModPro.IdProveedor);
                Modificar.Parameters.AddWithValue("@descripcion", ModPro.Descripcion);
                Modificar.Parameters.AddWithValue("@frank", ModPro.Frank);
                Modificar.Parameters.AddWithValue("@Pre_compraSol", ModPro.Pre_compraSol);
                Modificar.Parameters.AddWithValue("@StockActual", ModPro.StockActual);
                Modificar.Parameters.AddWithValue("@idCat", ModPro.IdCat);
                Modificar.Parameters.AddWithValue("@idMar", ModPro.IdMar);
                Modificar.Parameters.AddWithValue("@Pre_Venta_Menor", ModPro.Pre_Venta_Menor);
                Modificar.Parameters.AddWithValue("@Pre_Venta_Mayor", ModPro.Pre_Venta_Mayor);
                Modificar.Parameters.AddWithValue("@UndMdida", ModPro.UndMdida);
                Modificar.Parameters.AddWithValue("@Utilidad", ModPro.Utilidad);
                Modificar.Parameters.AddWithValue("@TipoProd ", ModPro.TipoProd);
                Modificar.Parameters.AddWithValue("@Foto  ", ModPro.Foto);
                Modificar.Parameters.AddWithValue("@ValorporProd ", ModPro.ValorporProd);

                cn.Open();
                Modificar.ExecuteNonQuery();
                cn.Close();

                edito = true;
            }
            catch (Exception Ex)
            {
                edito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo Modificar los datos" + Ex.Message, "BD_Modificar_Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void BD_Actulizar_Precios_Compra_Venta_Producto(string Id_Pro, string Pre_CompraS, string Pre_vntaxMenor, string Utilidad, string ValorAlmacen)

        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand Actualizar_Producto = new SqlCommand("Sp_Actulizar_Precios_CompraVenta_Producto", cn);
                Actualizar_Producto.CommandTimeout = 20;
                Actualizar_Producto.CommandType = CommandType.StoredProcedure;
                Actualizar_Producto.Parameters.AddWithValue("@Id_Pro", Id_Pro);
                Actualizar_Producto.Parameters.AddWithValue("@Pre_CompraS", Pre_CompraS);
                Actualizar_Producto.Parameters.AddWithValue("@Pre_vntaxMenor", Pre_vntaxMenor);
                Actualizar_Producto.Parameters.AddWithValue("@Utilidad", Utilidad);
                Actualizar_Producto.Parameters.AddWithValue("@ValorAlmacen ", ValorAlmacen);

                cn.Open();
                Actualizar_Producto.ExecuteNonQuery();
                cn.Close();

                seguardo = true;
            }
            catch (Exception Ex)
            {
                seguardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo restar" + Ex.Message, "BD_Producto BD_Insertar_Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void BD_Sumar_stock_Producto(string v, string a)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand sumar = new SqlCommand("sp_SumarStock", cn);
                sumar.CommandTimeout = 20;
                sumar.CommandType = CommandType.StoredProcedure;
                sumar.Parameters.AddWithValue("@idpro", v);
                sumar.Parameters.AddWithValue("@stock", a);

                cn.Open();
                sumar.ExecuteNonQuery();
                cn.Close();

                seguardo = true;

            }
            catch (Exception Ex)
            {
                seguardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("No se pudo insertar Producto" + Ex.Message, "BD_Producto BD_Insertar_Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
