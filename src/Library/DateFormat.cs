﻿using System;

namespace Library
{
    public class DateFormat
    {
        public static string FechaConBarras_RetornaFechaInvertidaConGuiones(string cadena)
        {
            string fecha= cadena.Replace("/","-");
            return fecha.Substring(6)+fecha.Substring(2,4)+fecha.Substring(0,2);
        }
    }
}
