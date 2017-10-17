using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryMinero : IFactoryTropaNormal
    {
    
        public ITropaNormal Instanciar(Aldea aldea)
        {
            return new Minero(aldea);
        }
    }
}
