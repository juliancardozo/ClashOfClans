using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryRecolectoraElixirRojo: IFactoryRecolectora
    {
    
        public IRecolectora Instanciar(Aldea aldea)
        {
            return new RecolectoraElixirRojo(aldea);
        }
    }
}
