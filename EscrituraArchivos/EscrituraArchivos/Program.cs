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

    class Program
    {

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            // si el archivo no existe -- lo creara
            // si ya existe, escribira en el
            //true es para agregar y no sobreescribir

            string[] lines = {
                "Esta es la informacion de la primera linea",
                "Esta es la segunda linea",
                "Fin del texto"
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
