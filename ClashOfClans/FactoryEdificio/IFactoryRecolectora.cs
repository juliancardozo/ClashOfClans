using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    interface IFactoryRecolectora
    {
        IRecolectora Instanciar(Aldea aldea);
    }
}
