using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public class FactoryAlmacenElixirRojo : IFactoryAlmacen
    {
    
        public IAlmacen Instanciar(Aldea aldea)
        {
            return new AlmacenElixirRojo(aldea);
        }
    }
}
