using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class BD_Conexion
    {
        public string Conectar()
        {
            /*
              esta es la manera que se conecta mediente una autenticacion de windows
              string Conectando = "data source = LAPTOP-1PHRBETR;Initial Catalog = POS_Microsell_Lite; Integrated Segurity = true ";
            */

            /*
                data source: es el nombre del servidor
                Initial Catalog: es la base de dato o sea el nombre con la cual se esta trabajando
                uid: es el usuario
                pwd: es la contraseña del servidor
                este es la manera que se conecta a la base de datos con contraseña y usuario
            */
            string Conectando = "data source = enmanuel;Initial Catalog = EnmaSoftwarePuntoVenta; uid = sa; pwd = 100402256";
            return Conectando; // estoy devolviendo la cadena de conecion 

        }
        public static string Conectar2()
        {
            /*
              esta es la manera que se conecta mediente una autenticacion de windows
              string Conectando = "data source = LAPTOP-1PHRBETR;Initial Catalog = POS_Microsell_Lite; Integrated Segurity = true ";
            */

            /*
                data source: es el nombre del servidor
                Initial Catalog: es la base de dato o sea el nombre con la cual se esta trabajando
                uid: es el usuario
                pwd: es la contraseña del servidor
                este es la manera que se conecta a la base de datos con contraseña y usuario
            */
            string Conectando = "data source = enmanuel;Initial Catalog = EnmaSoftwarePuntoVenta; uid = sa; pwd = 100402256";
            return Conectando; // estoy devolviendo la cadena de conecion 

        }
    }
}
