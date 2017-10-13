using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryArquera : IFactory
    {
    
        public ITropa Instanciar(Aldea aldea)
        {
            return new Arquera(aldea);
        }
    }
}
