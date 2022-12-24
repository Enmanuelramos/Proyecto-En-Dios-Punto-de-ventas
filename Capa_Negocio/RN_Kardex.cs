using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class RN_Kardex
    {
        public void RN_Registrar_Kaxdex(string idKardex, string idProvee, string idProduct)
        {
            BD_Kardex Kar = new BD_Kardex();
            Kar.BD_Registrar_Kaxdex(idKardex, idProvee, idProduct);
        }
        public void RN_Registrar_Detalle_Kardex(EN_Kardex EnKAr)
        {
            BD_Kardex kar = new BD_Kardex();
            kar.BD_Registrar_Detalle_Kardex(EnKAr);
        }
        public bool BD_Verificar_Producto_SiTieneKardex(string idprod)
        {
            BD_Kardex kar = new BD_Kardex();
            return kar.BD_Verificar_Producto_SiTieneKardex(idprod);
        }
        public DataTable RN_Buscar_KardexDetalle_porProducto(string idPro)
        {
            BD_Kardex kar = new BD_Kardex();
            return kar.BD_Buscar_KardexDetalle_porProducto(idPro);
        }
        
    }
}
