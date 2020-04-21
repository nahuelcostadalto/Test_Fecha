using System;

namespace Library
{
    public class ParaTest2
    {
        public static string FechaConBarras_FechaConGuiones(string cadena)
        {
            string fecha= cadena.Replace("/","-");
            return fecha.Substring(0,2)+fecha.Substring(2,4)+fecha.Substring(6);
        }
    }
}