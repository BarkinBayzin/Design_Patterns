﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    abstract class PrototypeGame
    {
        public abstract PrototypeGame Clone();
    }
}
