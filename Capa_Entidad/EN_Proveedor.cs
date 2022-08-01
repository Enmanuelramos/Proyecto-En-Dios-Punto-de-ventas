using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EN_Proveedor

    {
        private string _Idproveedor;
        private string _Nombre;
        private string _Direccion;
        private string _Telefono;
        private string _Rubro;
        private string _Ruc;
        private string _Correo;
        private string _Contacto;
        private string _Fotologo;

        public string Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Rubro { get => _Rubro; set => _Rubro = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Contacto { get => _Contacto; set => _Contacto = value; }
        public string Fotologo { get => _Fotologo; set => _Fotologo = value; }
        public string Ruc { get => _Ruc; set => _Ruc = value; }
    }
}
