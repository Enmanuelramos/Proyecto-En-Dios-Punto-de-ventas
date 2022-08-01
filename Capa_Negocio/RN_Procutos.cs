using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class RN_Procutos
    {
       public void RN_Insertar_Productos(EN_Productos v)
        {
            BD_Productos Product = new BD_Productos();
            Product.BD_Insertar_Productos(v);
        }
    }
}
