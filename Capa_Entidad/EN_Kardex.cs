using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
   public class EN_Kardex
    {
        private string _idKardex;
        private int _item;
        
        private string _doc_soporte;
        private string _det_operacion;

        private string _cantidad_In;
        private string _precio_Unit_In;
        private string _costo_Total_In;

        private string _cantidad_Out;
        private string _precio_Unt_Out;
        private string _Importe_Total_Out;

        private string _cantidad_Saldo;
        private string _promedio;
        private string _Costo_Total_Saldo;

        public string IdKardex { get => _idKardex; set => _idKardex = value; }
        public int Item { get => _item; set => _item = value; }
        public string Doc_soporte { get => _doc_soporte; set => _doc_soporte = value; }
        public string Det_operacion { get => _det_operacion; set => _det_operacion = value; }
        public string Cantidad_In { get => _cantidad_In; set => _cantidad_In = value; }
        public string Precio_Unit_In { get => _precio_Unit_In; set => _precio_Unit_In = value; }
        public string Costo_Total_In { get => _costo_Total_In; set => _costo_Total_In = value; }
        public string Cantidad_Out { get => _cantidad_Out; set => _cantidad_Out = value; }
        public string Precio_Unt_Out { get => _precio_Unt_Out; set => _precio_Unt_Out = value; }
        public string Importe_Total_Out { get => _Importe_Total_Out; set => _Importe_Total_Out = value; }
        public string Cantidad_Saldo { get => _cantidad_Saldo; set => _cantidad_Saldo = value; }
        public string Promedio { get => _promedio; set => _promedio = value; }
        public string Costo_Total_Saldo { get => _Costo_Total_Saldo; set => _Costo_Total_Saldo = value; }
    }
}
