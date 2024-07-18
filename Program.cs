using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_uygulamasi1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Karakter Girin:");
            char ch = (char)Console.Read();

            if (char.IsUpper(ch))
            {
                Console.WriteLine("Girilen Karakter Büyük Bir Karakter");
            }

            else if (char.IsLower(ch))
            {
                Console.WriteLine("Girilen Karakter Küçük Bir Karakter");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("Girilen Karakter Bir Rakamdır");
            }
            else
            {
                Console.WriteLine("Karakter Alfanumerik Bir Karakter değildir");
            }

        }
    }
}
