using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton2Sinav2coffee
{
    public class Kasa : Konum
    {
        public event EventHandler KasaSiparisGeldi;

        public KasaCalisani Calisani { get; set; }

        public Siparis Siparis { get {return  Calisani.Siparis; } }

        public override void CalisanEkle(Calisan calisan)
        {
            if (Calisani != null)
            {
                throw new Exception("Bu kasada calisan zaten var");
            }
            else
            {
                Calisani = new KasaCalisani(calisan, this);
                this.Calisani.SiparisGeldi += Calisan_Siparis_Geldi;
            }
        }


        private void Calisan_Siparis_Geldi(object sender, EventArgs e)
        {
            if (KasaSiparisGeldi!= null)
            {

            }
        }

    }
}
