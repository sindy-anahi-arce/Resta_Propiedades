using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resta_Propiedades
{
    class clresta
    {
        //Atributos
        private int num1;
        private int num2;

        //Propiedades
        public int Nume1
        {
            get => num1; set => num1 = value;
        }
        public int Nume2
        {
            get => num2; set => num2 = value;
        }

        //Método
        public int resta()
        {
            return (num1 - num2);
        }
    }
}
