using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Musteri = new MyDictionary<int, string>();
            Musteri.Add(1, "Adana");
            Musteri.Add(2, "Konya");
            Musteri.Add(3, "İstanbul");
            Musteri.Add(4,  "Antalya");


        }
    }
}
