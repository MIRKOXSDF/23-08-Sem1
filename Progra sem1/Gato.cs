using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_sem1
{
    class Gato : Development
    {
        public Gato(int a) : base(a)
        {

        }
        public override void Mensaje()
        {
            Console.WriteLine("Yo soy el gato el que hace bulla");

        }

    }
}
