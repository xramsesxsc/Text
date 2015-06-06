using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIBNEGOCIO
{
    class ClsConexion
    {
        public static string Neptuno
        {
            get
            {
                return "Server=localhost;" +
                    "Integrated Security=SSPI;" +
                    "Database=Neptuno";
            }
        }
    }
}
