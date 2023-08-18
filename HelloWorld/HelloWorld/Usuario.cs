using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Usuario
    {
        private string _nombre;
        private string _apellido;
        private int _edad;


        public string nombre
        {
            get { return _nombre; }
            private set { _nombre = value;}
        }

        public string apellido
        {
            get { return _apellido; }
            private set { _apellido = value; }
        }

        public int edad
        {
            get { return _edad; }
            private set { _edad = value; }
        }

        public Usuario(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
           
        }   

        public void Saludar()
        {
            Console.WriteLine($"Hola {nombre} {apellido}!" );
        }   

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }
    }
}
