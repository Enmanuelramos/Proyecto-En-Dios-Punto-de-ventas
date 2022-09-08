using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EN_Clientes
    {
        //@idcliente char (10),
        //@razonsocial varchar(250),
        //@dni char (18),
        //@direccion varchar(150),
        //@telefono char (10),
        //@email varchar(150),
        //@idDis int,
        //@fechaAniver date,
        //@contacto varchar(50),
        //@limiteCred real

        private string _idcliente;
        private string _razonsocial;
        private string _dni;
        private string _direccion;
        private string _telefono;
        private string _emiel;
        private int _idDis;
        private DateTime _fechaAniver;
        private string _contacto;
        private string _limiteCred;

        public string Idcliente { get => _idcliente; set => _idcliente = value; }
        public string Razonsocial { get => _razonsocial; set => _razonsocial = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Emiel { get => _emiel; set => _emiel = value; }
        public int IdDis { get => _idDis; set => _idDis = value; }
        public string Contacto { get => _contacto; set => _contacto = value; }
        public string LimiteCred { get => _limiteCred; set => _limiteCred = value; }
        public DateTime FechaAniver { get => _fechaAniver; set => _fechaAniver = value; }
    }
}
