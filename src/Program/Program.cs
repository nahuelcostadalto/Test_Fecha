using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   string fecha="03/20/1998";
            Console.WriteLine($"{fecha} se convierte a:{date_format("03/20/1998")}");
        }
        public static string date_format(string cadena)
        {
            string fecha= cadena.Replace("/","-");
            return fecha.Substring(6)+fecha.Substring(2,4)+fecha.Substring(0,2);
        }
    }
}

