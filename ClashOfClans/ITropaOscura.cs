using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{

    /// <summary>
    /// Hereda de ITropa e IOscura, todas las tropas oscuras seran creadas en una lista ITropaOscura
    /// </summary>
    /// 

    public interface ITropaOscura :ITropa,IOscura
    {
    }
}
