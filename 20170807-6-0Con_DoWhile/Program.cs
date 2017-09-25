using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170807_6_0Con_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // while göngüsü ile aynı işlemi yapar ancak do kısmında while ne olursa olsun 1 kere çalıştırılır.
            /*
                do
                {
                   işlemler
                } while (koşul);
            */

            // normal şartlarda döngünün false koşulu aldığı için çalışmaması gerekir.
            // Ancak do işlemi ilk olarak yapılacağı için ekrana merhaba dünya yazdıktan sonra 
            // while koşulu kontrol edileceği için 1 kere merhaba dünya yazılır.
            // 20170807-6Con_SayiTahminOyunu projesinde detaylı bir örnek bulunmaktadır.
            do
            {
                Console.Write("Merhaba dünya");
            } while (false);
        }
    }
}
