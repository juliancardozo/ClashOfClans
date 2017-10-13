using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public interface IEdificio
    {
        String nombre { get; }
        Int32 vida { get; }

        Int32 nivel { get;  }
        Aldea aldea { get; set; }


    }
}
