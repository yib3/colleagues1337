﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Factory
    {
        public static Salad CreateSalad()
        {
            Salad salad = new Salad();
            return salad;
        }
    }
}
