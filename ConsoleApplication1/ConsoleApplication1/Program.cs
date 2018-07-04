using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona aux = new Persona();
            int edadT;
            String nombreT;
            aux.setNombre("Josesito");
            aux.setEdad(int.Parse(Console.ReadLine()));
            Console.Read();
            edadT = aux.getEdad();
            nombreT = aux.getNombre();
            Console.Read();
            Console.WriteLine("La edad es "+edadT+" y su nombre: "+nombreT);
            Console.Read();
            
        }
    }
}
