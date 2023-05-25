using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton2Sinav2coffee.InterFace
{
    public interface IKasaCalisani
    {
        event EventHandler SiparisGeldi;

        void SiparisAl(Siparis siparis);

        Siparis SiparisVer(Calisan calisan);

    }

    
}
