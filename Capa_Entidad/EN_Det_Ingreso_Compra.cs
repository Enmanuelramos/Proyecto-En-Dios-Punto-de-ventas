using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EN_Det_Ingreso_Compra
    {
        private string _Id_ingreso;
        private string _Id_Pro;
        private string _Precio;
        private string _Cantidad;
        private string _Importe;

        public string Id_ingreso { get => _Id_ingreso; set => _Id_ingreso = value; }
        public string Id_Pro { get => _Id_Pro; set => _Id_Pro = value; }
        public string Precio { get => _Precio; set => _Precio = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Importe { get => _Importe; set => _Importe = value; }
    }
}
