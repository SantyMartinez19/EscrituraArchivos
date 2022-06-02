using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // <-- libreria para subir los archivos

namespace EscrituraArchivos
{
    
    //Nombre: Santy Francisco Martinez Castellanos
    //N.Control: 21211989


    public class DatosControl
    {
        string nombre;
        string apellidos;
        string carrera;
        string numerocontrol;
        
        public DatosControl(string nombre, string apellidos, string carrera, string numerocontrol)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.carrera = carrera;
            this.numerocontrol = numerocontrol;
        }
        
         public void Muestra()
        {
            Console.WriteLine("~~Datos a Guardar~~");
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Apellidos: {0}", apellidos);
            Console.WriteLine("Carrera: {0}", carrera);
            Console.WriteLine("Numero de control: {0}", numerocontrol);
        }
  

    }

    class Program
    {

        static void Main(string[] args)
        {
            string nombre;
            string apellidos;
            string carrera;
            string numerocontrol;


            Console.WriteLine("~~DATOS DEL ESTUDANTE~~");
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresa tus apellidos: ");
            apellidos = Console.ReadLine();
            Console.Write("Ingresa tu carrera: ");
            carrera = Console.ReadLine();
            Console.Write("Ingresa tu numero de control: ");
            numerocontrol = Console.ReadLine();
            Console.WriteLine("Presione enter");
            Console.ReadKey();
            Console.Clear();

            DatosControl da = new DatosControl(nombre, apellidos, carrera, numerocontrol);
            
            da.Muestra();
            Console.ReadKey();
            Console.Clear();
            
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            // si el archivo no existe -- lo creara
            // si ya existe, escribira en el
            //true es para agregar y no sobreescribir

            string[] lines = {
                
                "Nombre" + "\t\t" + "Apellidos" + "\t\t\t" + "Carrera" + "\t\t\t\t" + "N.Control",

                nombre+"\t"+apellidos+"\t"+carrera+"\t"+numerocontrol
                
            };

            //Recorre el arreglo
            foreach(string line in lines)
            {
                sw.WriteLine(line);
            }

            sw.Close();

            Console.WriteLine("Escribiendo en el archivo...");
            
            
                
        }
    }
}
