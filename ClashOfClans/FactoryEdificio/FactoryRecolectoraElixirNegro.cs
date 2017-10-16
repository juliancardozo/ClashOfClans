using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryRecolectoraElixirNegro: IFactoryRecolectora
    {
    
        public IRecolectora Instanciar(Aldea aldea)
        {
            return new RecolectoraElixirNegro(aldea);
        }
    }
}
