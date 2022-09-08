using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class RN_Clientes
    {
        public bool RN_Verificar_Numero_CLiente_DNI(string idpCli)
        {
            BD_Cliente CliDNI = new BD_Cliente();
            return CliDNI.BD_Verificar_Numero_CLiente_DNI(idpCli);
        }
        public void RN_Insetar_Cliente(EN_Clientes V)
        {
            BD_Cliente CliIns = new BD_Cliente();
            CliIns.BD_Insetar_Cliente(V);
        }
        public void RN_ModificarCliente(EN_Clientes V)
        {
            BD_Cliente CliMod = new BD_Cliente();
            CliMod.BD_ModificarCliente(V);
        }
        public DataTable RN_Bucar_Cliente(string valor, string Estado)
        {
            BD_Cliente CliMos = new BD_Cliente();
            return CliMos.BD_Bucar_Los_Cliente( valor,Estado);
        }
        public void RN_DarDeBaja_Cliente(string V)
        {
            BD_Cliente CliDar = new BD_Cliente();
            CliDar.BD_DarDeBaja_Cliente(V);
        }
        public void RN_Eliminar_Cliente(string V)
        {
            BD_Cliente CliEli = new BD_Cliente();
            CliEli.BD_Eliminar_Cliente(V);
        }
        public DataTable RN_Listar_Clientes(string v)
        {
            BD_Cliente CliLis = new BD_Cliente();
            return CliLis.BD_Listar_Clientes(v);
        }
    }
}
