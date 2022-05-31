using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);

            string[] lines = {
                "Esta es la información de la primera línea",
                "Esta es la segunda línea",
                "Fin del texto"
            };

            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadKey();
        }
    }
}
