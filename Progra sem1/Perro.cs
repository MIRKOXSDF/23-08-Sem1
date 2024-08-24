using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_sem1
{
    class Perro : Development
    {
        public Perro(int a) :base(a)
        {

        }
        public override void Mensaje()
        {
            Console.WriteLine("Soy yo el que hace buya");
        }

    }
}
