using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_interfaces.MisInterfaces
{
    internal interface IPersona
    {
        String Nombre { get; }
        int Edad { get; }
        void DecirMiNombre();
        void cumplirAños(int año);
    }
}
