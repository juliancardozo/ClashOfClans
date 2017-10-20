using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public interface IAlmacen :IEdificio
    {
        Int32 capacidadMaxima { get; set; }
        Int32 disponible { get; set; }

        

    }
}
