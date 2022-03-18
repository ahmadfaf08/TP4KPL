using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HaloGeneric
{
    public static void SapaUser<R>(R nama)
    {
        Console.WriteLine("Halo User " + nama);

    }
}

namespace tpmodul4_1302200084
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nama User: ");

            String a = Console.ReadLine();
            HaloGeneric.SapaUser<String>(a);

        }
    }
}
