﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public interface IFactoryTropaOscura
    {
       ITropaOscura Instanciar(Aldea aldea);
    }
}
