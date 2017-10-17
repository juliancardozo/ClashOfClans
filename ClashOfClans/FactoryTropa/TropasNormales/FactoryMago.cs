using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryMago : IFactoryTropaNormal
    {
    
        public ITropaNormal Instanciar(Aldea aldea)
        {
            return new Mago(aldea);
        }
    }
}
