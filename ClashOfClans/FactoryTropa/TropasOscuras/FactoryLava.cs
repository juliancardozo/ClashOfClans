using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryLava : IFactoryTropaOscura
    {
    
        public ITropaOscura Instanciar(Aldea aldea)
        {
            return new Lava(aldea);
        }
    }
}
