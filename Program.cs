using System;

namespace odev_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort sıralama
            int[] sayidizisi = {23,12,4,86,72,3,11,17,};
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("******Sıralı Dizi********");
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear 
             Console.WriteLine("******Clear********");
            Array.Clear(sayidizisi,2,3); // 2. indexten başlayarak 3 tane değeri sıfırladı
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("******Reverse********");
            //Reverse ters çeviri
            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            // index of (aranan değerin sırasını söyler)
            Console.WriteLine("******indexOf********");
            Console.WriteLine(Array.IndexOf(sayidizisi,23));
            


        }
    }
}
