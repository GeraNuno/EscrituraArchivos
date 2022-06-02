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
            public float calif1, calif2, calif3;

            public Alumnos(string nombre, string apellidoP, string apellidoM, int edad, int numControl, float calif1, float calif2, float calif3)
            {
                this.nombre = nombre;
                this.apellidoP = apellidoP;
                this.apellidoM = apellidoM;
                this.edad = edad;
                this.numControl = numControl;
                this.calif1 = calif1;
                this.calif2 = calif2;
                this.calif3 = calif3;
            }
            public float Promedio()
            {
                if (calif1 > 100)
                {
                    calif1 = 100;
                }
                else if (calif2 > 100) 
                {
                    calif2 = 100;
                }
                else if(calif3 > 100)
                {
                    calif3 = 100;
                }
                else if (calif1 < 0)
                {
                    calif1 = 0;
                }
                else if (calif2 < 0)
                {
                    calif2 = 0;
                }
                else if (calif3 < 0)
                {
                    calif3 = 0;
                }
                return (calif1 + calif2 + calif3) / 3;
            }
            public void Datos()
            {
                Console.WriteLine("Nombre Alumno: " + nombre + " " + apellidoP + " " + apellidoM);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("No. Control: " + numControl);
                Console.WriteLine("Promedio: " + Promedio());
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("alumnos.txt", true);

            string nombre, apellidoP, apellidoM;
            int edad, numControl, opc;
            float calif1, calif2, calif3;

            do
            {
                Console.WriteLine("----- Captura de Alumnos -----");

                Console.Write("\n¿Desea registrar un Alumno?\n1) Si\n2) No\n\nElija la opción: ");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opc)
                {
                    case 1:
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
                        Console.Write("Calificación periodo 1: ");
                        calif1 = float.Parse(Console.ReadLine());
                        Console.Write("Calificación periodo 2: ");
                        calif2 = float.Parse(Console.ReadLine());
                        Console.Write("Calificación periodo 3: ");
                        calif3 = float.Parse(Console.ReadLine());
                        Console.Clear();

                        Alumnos al = new Alumnos(nombre, apellidoP, apellidoM, edad, numControl, calif1, calif2, calif3);

                        sw.WriteLine("Nombre Alumno: " + al.nombre + " " + al.apellidoP + " " + al.apellidoM + "\nEdad: " + al.edad + " años\nNo. Control: " + al.numControl + "\nPromedio: " + al.Promedio() + "\n");

                        Console.WriteLine("Alumno registrado exitosamente!!!\nDatos del Alumno\n");
                        al.Datos();
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Presione ENTER para salir del programa...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Error, elija una opción correcta!\nPresione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opc != 2);
            sw.Close();
        }
    }
}
