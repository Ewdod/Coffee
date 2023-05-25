using Maraton2Sinav2coffee.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton2Sinav2coffee
{
    public class KasaCalisani :  IKasaCalisani
    {

        public KasaCalisani(Calisan calisan,Kasa kasa)
        {
            Calisan = calisan;
            Kasa = kasa;
            Calisan.Konum = kasa;
        }

        public event EventHandler SiparisGeldi;
        public Kasa Kasa { get; set; }

        public Calisan Calisan;
        private Siparis _siparis;

        public Siparis Siparis
        {
            get { return _siparis; }
            private set
            {
                if (value == null)
                {
                    _siparis = null;
                }
                else
                {
                    _siparis = value;
                    if (SiparisGeldi != null)
                        SiparisGeldi(this, null);
                    else
                        throw new Exception("Siparis Alamiyorum");
                }

            }
        }





        public void SiparisAl(Siparis siparis)
        {
            throw new NotImplementedException();
        }

        public Siparis SiparisVer(Calisan calisan)
        {
            throw new NotImplementedException();
        }
    }
}
