using Ejercicio4_interfaces.MisInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_interfaces.MisClases
{
    internal class Alumno : IPersona
    {
        public string Nombre { get; }
        public int Edad { get; }

        private string _nombre;
        private int _edad;

        public Alumno(string nombre, int edad)
        {
            this._nombre = nombre;
            this._edad = edad;
        }

        public string nombre => _nombre;
        public int edad => _edad;

        public void DecirMiNombre()
        {
            Console.WriteLine("Mi nombre es " + nombre);
        }

        public void cumplirAños(int edad)
        {
            Console.WriteLine("Mi edad es " + edad);
        }
    }
}
