using System;
using System.Security.AccessControl;
using libreriaClase;

namespace libreria
{

    class Pricipal{

        static void Main(){

            string opcion;

            Console.WriteLine("Menu");
            Console.WriteLine("----");

            Console.WriteLine("");
            Console.WriteLine("1.- Crear Alumno");
            Console.WriteLine("");
            Console.WriteLine("Elija una opcion: ");

            opcion = Console.ReadLine();

            if (opcion == "1"){

                crearPersona();

            }
            else
            {
                Console.WriteLine("opcion incorrecta...");
            }

           }

           public static void crearPersona(){

            Console.Clear();
            Persona p1 = new Persona();

            Console.Write("Ingrese Nombre: ");
            p1.Nombre = Console.ReadLine();

             Console.Write("Ingrese Apellido: ");
            p1.Apellido = Console.ReadLine();
            
             Console.Write("Ingrese FechaNacimiento: ");
            p1.FechaNacimiento = Console.ReadLine();

             Console.Write("Ingrese DNI: ");
            p1.DNI = Convert.ToInt32(Console.ReadLine());
        }



        }

        
    }
    
