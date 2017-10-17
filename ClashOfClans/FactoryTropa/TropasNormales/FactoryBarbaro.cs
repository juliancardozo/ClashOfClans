using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryBarbaro : IFactoryTropaNormal
    {
    
        public ITropaNormal Instanciar(Aldea aldea)
        {
            return new Barbaro(aldea);
        }
    }
}
