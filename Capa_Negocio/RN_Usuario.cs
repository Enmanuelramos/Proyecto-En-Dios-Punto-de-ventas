using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class RN_Usuario
    {
        public bool RN_Login(string UsuAri, string UsuCOn)
        {
            BD_Usuario Usu = new BD_Usuario();
            return Usu.BD_Login(UsuAri, UsuCOn);
        }
        public DataTable RN_BuscarUsuario(string NomUsu)
        {
            BD_Usuario Usu = new BD_Usuario();
            return Usu.BD_BuscarUsuario(NomUsu);
        }
    }
}
