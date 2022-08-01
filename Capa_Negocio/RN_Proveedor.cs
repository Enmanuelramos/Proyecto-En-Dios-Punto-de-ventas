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
    public class RN_Proveedor
    {
        public void RN_Insertar_Proveedor(EN_Proveedor v)
        {
            BD_Proveedor Inserp = new BD_Proveedor();
            Inserp.BD_Insertar_Proveedor(v);
        }
        public void RN_Modificar_Proveerdor(EN_Proveedor v)
        {
            BD_Proveedor Modip = new BD_Proveedor();
            Modip.BD_Modificar_Proveerdor(v);
        }
        public DataTable RN_Mostrar_Proveerdor()
        {
            BD_Proveedor Mospro = new BD_Proveedor();
            return Mospro.BD_Mostrar_Proveerdor();
        }
        public DataTable RN_Buscar_Proveerdor(string v)
        {
            BD_Proveedor Buscar = new BD_Proveedor();
            return Buscar.BD_Buscar_Proveerdor(v);
        }
    }
}
