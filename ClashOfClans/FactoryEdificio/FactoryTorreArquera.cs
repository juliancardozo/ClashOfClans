using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryTorreArquera: IFactoryEdificio
    {
    
        public IEdificio Instanciar(Aldea aldea)
        {
            return new TorreArquera(aldea);
        }
    }
}
