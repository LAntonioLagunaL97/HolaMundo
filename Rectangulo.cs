using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Rectangulo: Forma
    {
        public int GetArea()
        {
            return (Altura * Base);
        }
    }
}
