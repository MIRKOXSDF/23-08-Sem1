using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_sem1
{

     class Development:IMetodos
    {
        float a;
        float b=20f;
        int semanas=4;
        int count = 0;
        int[] array=new int[5];
        Semana semana;

        public Development(int a)
        {
            this.a = a;
        }
        public  virtual void Mensaje()
        {
            Console.WriteLine("Alguien hace buya???");
        }
        public void IforElse()
        {
            if(a<b)
            {
                Console.WriteLine("." + a + " es menor que " + b);
            }
            else
            {
                Console.WriteLine("." + b + " es mayor que " + a);

            }
        }
        public void Swicht()
        {
            semana = new Semana(14);
            switch (semanas)
            {
                case 1:
                    semana.EstadoSemana("Lunes");
                    break;
                case 2:
                    semana.EstadoSemana("Martes");
                    break;
                case 3:
                    semana.EstadoSemana("Miercoles");
                    break;
                case 4:
                    semana.EstadoSemana("Jueves");
                    break;
                case 5:
                    semana.EstadoSemana("Viernes");
                    break;
                case 6:
                    semana.EstadoSemana("Sabado");
                    break;
                case 7:
                    semana.EstadoSemana("Domingo");
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
        public void Sumar(int numero1 , int numero2)
        {
            
            Console.WriteLine("La suma es : " + numero1 + numero2);
        }
        public int Restar(int numero1 , int numero2)
        {
            int result = numero1 - numero2;
            Console.WriteLine("La resta es : " + result);
            return result;

        }

    }
}
