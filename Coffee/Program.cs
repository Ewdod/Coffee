using Maraton2Sinav2coffee;
using System.Collections;

namespace Coffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kasalar kasalar = new Kasalar();
            Kasa kasa = new Kasa();
            Kasa kasa2 = new Kasa();
            Calisan calisan = new Calisan();
            kasalar.Add(kasa);
            kasalar.Add(kasa2); 
            foreach (var item in kasalar) // generic enumerator
            {
                item.CalisanEkle(calisan);
            }

            IEnumerable enumerator = (IEnumerable)kasalar;
            foreach (var item in enumerator)
            {
                Console.WriteLine(((Kasa)(item)));
                
            }
        }
    }
}