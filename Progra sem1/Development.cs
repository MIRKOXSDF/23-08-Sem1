using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_sem1
{
   
    class Development
    {
        float a = 14f;
        float b = 20f;
        int semanas=3;
        int count = 0;
        int[] array=new int[5];
        public void IforElse()
        {
            if(a<b)
            {
                Console.WriteLine("-" + a + " es menor que " + b);
            }
            else
            {
                Console.WriteLine("-" + b + " es mayor que " + a);

            }
        }
        public void Swicht()
        {
            switch(semanas)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;

            }
        }
        public void For()
        {
            for (int i = 1; i <= 5; i++)
            {
                
                char letra = (char)(('A'-1) + i);
                count++;
                Console.WriteLine(letra + "." +count);
            }
        }
        public void While()
        {
            while(a>1)
            {
               

                a--;
                Console.WriteLine(a);

            }
        }
        public void Arreglo()
        {
            array[0]= 5;
            array[1] = 8;
            array[2] = 6;
            array[3] = 1;
            array[4] = 3;


            Console.WriteLine("Arreglos :");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }

    }
}
