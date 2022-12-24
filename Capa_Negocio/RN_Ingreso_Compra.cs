using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class RN_Ingreso_Compra
    {
        public void RN_ingreso_Compra(EN_Ingreso_Compra IngCom)
        {
            BD_Ingreso_Compra obj = new BD_Ingreso_Compra();
            obj.BD_ingreso_Compra(IngCom);
        }
        public void RN_Ingrese_Detalle_IngresoCompra(EN_Det_Ingreso_Compra DetCom)
        {
            BD_Ingreso_Compra obj = new BD_Ingreso_Compra();
            obj.BD_Ingrese_Detalle_IngresoCompra(DetCom);
        }
        public bool RN_Verificar_Numero_DoCum_Fisico(string NumFis)
        {
            BD_Ingreso_Compra obj = new BD_Ingreso_Compra();
            return obj.BD_Verificar_Numero_DoCum_Fisico(NumFis);
        }
        public DataTable RN_Cargar_Todas_Las_Compra()
        {
            BD_Ingreso_Compra obj = new BD_Ingreso_Compra();
            return obj.BD_Cargar_Todas_Las_Compra();
        }
        public DataTable RN_Buscar_Compra_Explorado(string v)
        {
            BD_Ingreso_Compra obj = new BD_Ingreso_Compra();
            return obj.BD_Buscar_Compra_Explorado(v);
        }
        public DataTable RN_Buscar_Compra_Explorado_Por_Dia_Mes(string v, DateTime FechMes)
        {
            BD_Ingreso_Compra obj = new BD_Ingreso_Compra();
            return obj.BD_Buscar_Compra_Explorado_Por_Dia_Mes(v, FechMes);
        }
        public void RN_Borrar_Compra_Factura(string IfaCom)
        {
            BD_Ingreso_Compra obj = new BD_Ingreso_Compra();
            obj.BD_Borrar_Compra_Factura(IfaCom);
        }
    }
}
