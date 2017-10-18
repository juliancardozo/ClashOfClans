using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    interface IProduccion:IEdificio
    {
        public Int32 cantidadMaxima { get; set; }
    }
}
