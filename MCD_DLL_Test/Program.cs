using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DLL_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MCD_DLL.Class1 MatematikselIslemler = new MCD_DLL.Class1();
            int sonuc = MatematikselIslemler.Toplama(80, 25);
            Console.WriteLine(sonuc);

            Console.ReadKey();

        }
    }
}
