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

            int cont = 0, turno = 1;
            string line;

            Console.Write("¿Cuántas personas va a capturar? ");
            cont = int.Parse(Console.ReadLine());

            while(turno <= cont)
            {
                Console.Write("Escriba el nombre de la persona " + turno + ": ");
                line = Console.ReadLine();
                sw.WriteLine(line);
                turno++;
                Console.Clear();
            }
            sw.Close();

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadKey();
        }
    }
}
