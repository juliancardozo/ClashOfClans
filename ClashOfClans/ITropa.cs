using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public interface ITropa
    {
        String nombre { get; }
        Int32 nivel { get; }
        Int32 velocidad { get; }
        Int32 dano { get; }
        Int32 espacio { get;}

        void Atacar();
    }
}
