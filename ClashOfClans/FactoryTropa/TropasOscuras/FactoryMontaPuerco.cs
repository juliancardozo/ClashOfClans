using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryMontaPuerco : IFactoryTropaOscura
    {
    
        public ITropaOscura Instanciar(Aldea aldea)
        {
            return new MontaPuerco(aldea);
        }
    }
}
