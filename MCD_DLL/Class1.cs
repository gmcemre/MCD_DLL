using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DLL
{
    public class Class1
    {
        public int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Bolme(int sayi1, int sayi2)
        {
            if (sayi2 == 0)
            {
                sayi2 = 1;
            }
            return sayi1 / sayi2;
        }
    }
}
