using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Herencia
    {
        static void Main(string[] args)
        {
            int Base = 0;
            int Altura = 0;

            Console.WriteLine("introduce la base");
            Base = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduce la altura ");
            Altura = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(Altura * Base);

            Rectangulo Rect = new Rectangulo();
            Rect.SetBase(Base);
            Rect.SetAltura(Altura);

            Console.WriteLine("El área es = {0}", Rect.GetArea());


            Console.ReadKey();


        }
    
    }
}
