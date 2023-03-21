using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210101
{
    internal class Penjumlahan<T>
    {
        public void JumlahTigaAngka(T satu,T dua,T tiga) { 
            float total = (dynamic)satu+dua+tiga;
            Console.WriteLine(total);
        }
    }
}
