﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateServiceMocker.Infrastructure
{
    public interface IViewModel
    {
           IView View { get; set; }
    }
}
