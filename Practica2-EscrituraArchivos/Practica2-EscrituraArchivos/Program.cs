using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Practica2_EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //si el archivo no existe, lo creara
            //si el archivo existe, escribira en el

            string[] Lineas =
            {
                "Esta es la primera linea",
                 "Esta es la segunda lineaa",
                 "Esta es la tercera linea"
        
            };
            foreach (string Linea in Lineas)
            {
                sw.WriteLine(Linea);
            }
            sw.Close();

            Console.WriteLine("Escribiendo ....");
            Console.ReadLine();


        }
    }
}
