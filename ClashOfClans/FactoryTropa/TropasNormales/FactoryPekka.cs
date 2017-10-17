using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryPekka : IFactoryTropaNormal
    {
    
        public ITropaNormal Instanciar(Aldea aldea)
        {
            return new Pekka(aldea);
        }
    }
}
