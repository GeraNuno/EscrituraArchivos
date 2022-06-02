using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace TareaArchivos
{
    class Program
    {
        public class Alumnos
        {
            public string nombre, apellidoP, apellidoM;
            public int edad, numControl;

            public Alumnos(string nombre, string apellidoP, string apellidoM, int edad, int numControl)
            {
                this.nombre = nombre;
                this.apellidoP = apellidoP;
                this.apellidoM = apellidoM;
                this.edad = edad;
                this.numControl = numControl;
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("alumnos.txt", true);

            string nombre, apellidoP, apellidoM;
            int edad, numControl, opc = 0;

            do
            {
                Console.WriteLine("----- Captura de Alumnos -----");
                Console.Write("\nNombre: ");
                nombre = Console.ReadLine();
                Console.Write("Apellido Paterno: ");
                apellidoP = Console.ReadLine();
                Console.Write("Apellido Materno: ");
                apellidoM = Console.ReadLine();
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Número de control: ");
                numControl = int.Parse(Console.ReadLine());

                Alumnos al = new Alumnos(nombre, apellidoP, apellidoM, edad, numControl);

                sw.WriteLine(al.nombre + "\t" + al.apellidoP + "\t" + al.apellidoM + "\t" + al.edad + "\t" + al.numControl);
                

                Console.Clear();
                Console.WriteLine("Alumno registrado exitosamente!!!");
                Console.Write("\n¿Desea seguir registrando?\n1) Si\n2) No\n\nElija la opción: ");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opc != 2);
            sw.Close();
            Console.WriteLine("Presione ENTER para salir del programa...");
            Console.ReadKey();
        }
    }
}
