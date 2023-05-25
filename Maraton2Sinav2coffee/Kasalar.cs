using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton2Sinav2coffee
{
    public class Kasalar : ICollection<Kasa>
    {
        public const int MaksimumKasaSayisi = 3;

        public List<Kasa> KasalarListe { get; set; }

        public int Count => KasalarListe.Count();

        public bool IsReadOnly => ((ICollection<Kasalar>)(KasalarListe)).IsReadOnly;

        public void Add(Kasa item)
        {
            if (KasalarListe.Count == MaksimumKasaSayisi)
            {
                throw new Exception("Daha fazla kasa ekleyemezsiniz");
            }
            else
            {

                KasalarListe.Add(item);
            }
        }

        public void Clear()
        {
            KasalarListe.Clear();
        }

        public bool Contains(Kasa item)
        {
            return KasalarListe.Contains(item);
        }

        public void CopyTo(Kasa[] array, int arrayIndex)
        {
            KasalarListe.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Kasa> GetEnumerator()
        {
            return KasalarListe.GetEnumerator(); // foreach ile donmemizi saglayan generic collection
        }

        public bool Remove(Kasa item)
        {
            return KasalarListe.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)(KasalarListe)).GetEnumerator(); // generic olmayan foreach ile kullanmamizi sagliyor
        }
    }
}
