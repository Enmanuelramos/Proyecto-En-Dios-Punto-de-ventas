using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EN_Productos
    {
        private string _idproducto;
        private string _idProveedor;
        private string _descripcion;
        private string _frank;
        private string _Pre_compraSol;
        private string _StockActual;
        private int _idCat;
        private int _idMar;
        private string _Foto;
        private string _Pre_Venta_Menor;
        private string _Pre_Venta_Mayor;
        private string _UndMdida;
        //private string _PesoUnit;
        private string _Utilidad;
        private string _TipoProd;
        private double _ValorporProd;

        public string Idproducto { get => _idproducto; set => _idproducto = value; }
        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Frank { get => _frank; set => _frank = value; }
        public string Pre_compraSol { get => _Pre_compraSol; set => _Pre_compraSol = value; }
        public string StockActual { get => _StockActual; set => _StockActual = value; }
        public int IdCat { get => _idCat; set => _idCat = value; }
        public int IdMar { get => _idMar; set => _idMar = value; }
        public string Foto { get => _Foto; set => _Foto = value; }
        public string Pre_Venta_Menor { get => _Pre_Venta_Menor; set => _Pre_Venta_Menor = value; }
        public string Pre_Venta_Mayor { get => _Pre_Venta_Mayor; set => _Pre_Venta_Mayor = value; }
        public string UndMdida { get => _UndMdida; set => _UndMdida = value; }
        //public string PesoUnit { get => _PesoUnit; set => _PesoUnit = value; }
        public string Utilidad { get => _Utilidad; set => _Utilidad = value; }
        public string TipoProd { get => _TipoProd; set => _TipoProd = value; }
        public double ValorporProd { get => _ValorporProd; set => _ValorporProd = value; }
    }
}
