using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace Capa_Negocio
{
    public class RN_Distrito
    {
        public void RN_Insertar_Distrito(string NombDis)
        {
            BD_Distrito Insertar = new BD_Distrito();
            Insertar.BD_Insertar_Distrito(NombDis);
        }
        public void RN_Editar_Distrito(int idDis, string nomdis,string EstDis)
        {
            BD_Distrito Editar = new BD_Distrito();
            Editar.BD_Editar_Distrito(idDis, nomdis , EstDis);
        }
        public void RN_Eliminar_Distrito( int DisEli)
        {
            BD_Distrito Eliminar = new BD_Distrito();
            Eliminar.BD_Eliminar_Distrito(DisEli);
        }
        public DataTable RN_Motrar()
        {
            BD_Distrito Mostrar = new BD_Distrito();
            return Mostrar.Mostrar_Distrito();
        }
    }
}
