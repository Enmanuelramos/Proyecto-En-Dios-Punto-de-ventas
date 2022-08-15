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
    public class RN_Producto
    {
       public void RN_Insertar_Productos(EN_Productos v)
        {
            BD_Productos Product = new BD_Productos();
            Product.BD_Insertar_Productos(v);
        }
        public DataTable RN_Mostrar_Productos()
        {
            BD_Productos Product = new BD_Productos();
            return Product.Mostrar_Productos();
        }
        public DataTable RN_Buscar_Productos(string v)
        {
            BD_Productos product = new BD_Productos();
            return product.BD_Buscar_Productos(v);
        }
        public void RN_Modificar_Productos(EN_Productos ModPro)
        {
            BD_Productos product = new BD_Productos();
            product.BD_Modificar_Productos(ModPro);
        }
    }
}
