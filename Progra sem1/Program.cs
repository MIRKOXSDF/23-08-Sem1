﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_sem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Development development;
            development = new Development(14);
            development.IforElse();
            development.Swicht();
            development.For();
            development.While();
            development.Arreglo();
            Development development1 = new Perro(14);
            Development development2 = new Gato(14);


            development1.Mensaje();
            development2.Mensaje();
            development.Sumar(4, 5);
            development.Restar(10, 5);

            Comida comida = new Peces();
            comida.ComidaAnimales();
            development.Listas();
            development.Censo();
            Console.ReadLine();
        }
    }
}
