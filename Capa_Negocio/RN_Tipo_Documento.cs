using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class RN_Tipo_Documento
    {
        public static string RN_Numero_ID(int Id_Tipo)
        {
            return BD_TipoDocumento.BD_Numero_ID(Id_Tipo); // el tipo de datos static no se instancia se hace directamente
        }

        public static void RN_Actualizar_Tipo_Document(int Id_Tipo)
        {
            BD_TipoDocumento.BD_Actualizar_Tipo_Document(Id_Tipo);// el tipo de datos static no se instancia se hace directamente
        }
        public static void RN_Actualizar_tipo_de_Cambio(int Id_Tipo, double TIpCam)
        {
            BD_TipoDocumento.BD_Actualizar_tipo_de_Cambio(Id_Tipo, TIpCam);
        }
        public static double RN_Leer_Tipo_Cambio(int Id_Tipo)
        {
            return BD_TipoDocumento.BD_Leer_Tipo_Cambio(Id_Tipo);
        }
        public static void RN_Actualizar_Tipo_Document_CorelativoProducto(int Id_Tipo)
        {
            BD_TipoDocumento.BD_Actualizar_Tipo_Document_CorelativoProducto(Id_Tipo);
        }
    }
}
