using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Usuario
    {
        private string nombre;
        private string apellido;
        private int edad;

        public Usuario(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }   

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + nombre + " " + apellido + " y tengo " + edad + " años.");
        }   
    }
}
