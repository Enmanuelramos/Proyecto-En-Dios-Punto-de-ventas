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
    public class BD_Ingreso_Compra : BD_Conexion
    {
        public static bool guardar = false;
        public void BD_ingreso_Compra(EN_Ingreso_Compra IngCom)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand SqlCom = new SqlCommand("Sp_Registrar_Compra", cn);
                SqlCom.CommandTimeout = 20;
                SqlCom.CommandType = CommandType.StoredProcedure;

                SqlCom.Parameters.AddWithValue("@idCom", IngCom.IdCom);
                SqlCom.Parameters.AddWithValue("@Nro_Fac_Fisico", IngCom.Nro_Fac_Fisico);
                SqlCom.Parameters.AddWithValue("@IdProvee", IngCom.IdProvee);
                SqlCom.Parameters.AddWithValue("@SubTotal_Com", IngCom.SubTotal_Com);
                SqlCom.Parameters.AddWithValue("@FechaIngre", IngCom.FechaIngre);
                SqlCom.Parameters.AddWithValue("@TotalCompra", IngCom.TotalCompra);
                SqlCom.Parameters.AddWithValue("@IdUsu", IngCom.IdUsu);
                SqlCom.Parameters.AddWithValue("@ModalidadPago", IngCom.ModalidadPago);
                SqlCom.Parameters.AddWithValue("@TiempoEspera", IngCom.TiempoEspera);
                SqlCom.Parameters.AddWithValue("@FechaVence", IngCom.FechaVence);
                SqlCom.Parameters.AddWithValue("@EstadoIngre", IngCom.EstadoIngre);
                SqlCom.Parameters.AddWithValue("@RecibiConforme", IngCom.RecibiConforme);
                SqlCom.Parameters.AddWithValue("@Datos_Adicional", IngCom.Datos_Adicional);
                SqlCom.Parameters.AddWithValue("@Tipo_Doc_Compra", IngCom.Tipo_Doc_Compra);

                cn.Open();
                SqlCom.ExecuteNonQuery();
                cn.Close();

                guardar = true;

            }
            catch (Exception EX)
            {
                guardar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show(" Error al guardar el imgreso compra " + EX.Message, " Capa datos BD_ingreso_Compra ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static bool InsetoDetalle = false;

        public void BD_Ingrese_Detalle_IngresoCompra(EN_Det_Ingreso_Compra DetCom)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conectar();

                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandText = "Sp_Insert_Detalle_ingreso";
                Sqlcom.Connection = cn;
                Sqlcom.CommandTimeout = 20;
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.Parameters.AddWithValue("@Id_ingreso", DetCom.Id_ingreso);
                Sqlcom.Parameters.AddWithValue("@Id_Pro", DetCom.Id_Pro);
                Sqlcom.Parameters.AddWithValue("@Precio", DetCom.Precio);
                Sqlcom.Parameters.AddWithValue("@Cantidad", DetCom.Cantidad);
                Sqlcom.Parameters.AddWithValue("@Importe", DetCom.Importe);

                cn.Open();
                Sqlcom.ExecuteNonQuery();
                cn.Close();

                InsetoDetalle = true;

            }
            catch (Exception EX)
            {
                InsetoDetalle = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar el detalle de compra" + EX.Message, "Capa datos BD_Ingrese_Detalle_IngresoCompra", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public bool BD_Verificar_Numero_DoCum_Fisico(string NumFis)
        {
            bool Repuesta = false;
            Int32 getvalue = 0;

            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_validar_NroFisico_Compra";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nro_Doc_fisico", NumFis);

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

                MessageBox.Show("hay un Numero de Domumento fisico" + Ex.Message, "NO hay numero de Documento Fisico,BD_Verificar_Numero_DoCum_Fisico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return Repuesta;
        }
        public DataTable BD_Cargar_Todas_Las_Compra()
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter buscar = new SqlDataAdapter("Sp_Leer_Todas_Facturas_Compras", cn);
                buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
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
                MessageBox.Show("No se Puede buscar" + Ex.Message, "BD_ingreso_Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable BD_Buscar_Compra_Explorado(string v)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter buscar = new SqlDataAdapter("Sp_Buscador_Gnral_deCompras", cn);
                buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
                buscar.SelectCommand.Parameters.AddWithValue("@xvalo", v);
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
                MessageBox.Show("No se Puede buscar" + Ex.Message, "BD_Buscar_Compra_Explorador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable BD_Buscar_Compra_Explorado_Por_Dia_Mes(string v, DateTime FechMes)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter buscar = new SqlDataAdapter("Sp_Facturas_Ingresadas_alDia", cn);
                buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
                buscar.SelectCommand.Parameters.AddWithValue("@tipo ", v);
                buscar.SelectCommand.Parameters.AddWithValue("@fechat", FechMes);
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
                MessageBox.Show("No se Puede buscar" + Ex.Message, "BD_Buscar_Compra_Explorador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public void BD_Borrar_Compra_Factura(string IfaCom)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();

                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandText = "SP_Borrar_Factura_Ingresada";
                Sqlcom.Connection = cn;
                Sqlcom.CommandTimeout = 20;
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.Parameters.AddWithValue("@Id_Fac", IfaCom);


                cn.Open();
                Sqlcom.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception EX)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al borrar factura de compra" + EX.Message, "Capa datos BD_Borrar_Compra_Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
