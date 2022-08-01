using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class RN_Marca
    {
        public void RN_Insertar_Marca(string v)
        {
            BD_Marca marca = new BD_Marca();
            marca.BD_Insertar_Marca(v);
        }
        public void RN_Editar_Marca(int a, string v)
        {
            BD_Marca marca = new BD_Marca();
            marca.BD_Editar_Marca(a, v);
        }
        public void RN_Eliminar_Marca(int v)
        {
            BD_Marca marca = new BD_Marca();
            marca.BD_Eliminar_Marca(v);
        }
        public DataTable RN_Mostrar_Marca()
        {
            BD_Marca marca = new BD_Marca();
            return marca.Mostrar_Marca();
        }
    }
}
