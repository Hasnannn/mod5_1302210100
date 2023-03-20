using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210100
{
    internal class penjumlahan<T>
    {
        private T x;
        private T y;
        private T z;

        public void JumlahTigaAngka(T x, T y, T z)
        {
            dynamic hasil;
            hasil = (dynamic)x + (dynamic)y + (dynamic)z;
            Console.WriteLine(hasil);
        }
    }
}

