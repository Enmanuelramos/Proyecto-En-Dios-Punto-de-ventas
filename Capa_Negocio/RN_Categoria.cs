using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class RN_Categoria
    {
        public void RN_Registrar_Categoria(string v)
        {
            BD_Categoria ReGrt = new BD_Categoria();
            ReGrt.BD_Registrar_Categoria(v);
;        }
        public void RN_Editar_Categoria(int A, String v)
        {
            BD_Categoria EdiCat = new BD_Categoria();
            EdiCat.BD_Editar_Categoria(A,v);
        }
        public DataTable RN_Mostrar_categoria()
        {
            BD_Categoria Mosc = new BD_Categoria();
            return Mosc.BD_Mostrar_categoria();
        }
    }
}
