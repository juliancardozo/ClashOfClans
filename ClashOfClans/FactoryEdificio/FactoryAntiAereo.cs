using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryAntiAereo: IFactoryEdificio
    {
    
        public IEdificio Instanciar(Aldea aldea)
        {
            return new Antiaereo(aldea);
        }
    }
}
