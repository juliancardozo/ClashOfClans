using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryAlamcenElixirNegro: IFactoryEdificio
    {
    
        public IEdificio Instanciar(Aldea aldea)
        {
            return new AlmacenElixirNegro(aldea);
        }
    }
}
