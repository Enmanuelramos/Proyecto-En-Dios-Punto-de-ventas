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
    }
}
