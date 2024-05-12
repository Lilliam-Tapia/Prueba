using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil automovil = new Automovil("Toyota", "Ms 8903", "Corolla", "Azul", 33, 34);

            automovil.Conducir(100);

        }
    }
}
