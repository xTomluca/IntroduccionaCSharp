using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Persona
    {
        private int edad;
        String nombre;
        public int setEdad(int edad){
            this.edad = edad;
            return 0;
        }
        public int getEdad() {
            return this.edad;
        }
        public void setNombre(String nombre) {
            this.nombre = nombre;
        }
        public string getNombre() {
            return this.nombre;
        }
        
            
    }
}
