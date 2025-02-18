using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // <T> : T tipi demek. .net framework içerisinde olan veya bizim oluşturduğumuz herhangibir tip demek.

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<string > list2 = new List<string>();
            list2.Add("Halil");
            list2.Add("Hamza");
            list2.Add("Hakan");

            for(int i = 0  ; i < list2.Count ; i++)
            {
                Console.WriteLine(list2[i]);
            }
                 
            List<musteri> musteris = new List<musteri>();
            musteris.Add(new musteri()
            {
                id = 1,
                isim="Halil",
                soyisim = "Özcan"
            });

            foreach(musteri item in musteris)
            {
                Console.WriteLine(item.isim);
            }
        }
    }
}
