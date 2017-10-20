using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{

    /// <summary>
    /// Hereda de ITropa e INormal, todas las tropas normales seran creadas en una lista ITropaNormal
    /// </summary>

    public interface ITropaNormal :ITropa,INormal
    {
    }
}
