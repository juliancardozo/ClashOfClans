using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryCurandera : IFactoryTropaNormal
    {
    
        public ITropaNormal Instanciar(Aldea aldea)
        {
            return new Curandera(aldea);
        }
    }
}
