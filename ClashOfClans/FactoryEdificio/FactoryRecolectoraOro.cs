using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryRecolectoraOro: IFactoryRecolectora
    {
    
        public IRecolectora Instanciar(Aldea aldea)
        {
            return new RecolectoraOro(aldea);
        }
    }
}
