﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryBallesta: IFactoryDefensivo
    {
    
        public IDefensivo Instanciar(Aldea aldea)
        {
            return new Ballesta(aldea);
        }
    }
}
