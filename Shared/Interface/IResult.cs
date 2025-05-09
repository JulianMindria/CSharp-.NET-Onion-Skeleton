﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interface
{
    public interface IResult<T>
    {
        List<string> Messages { get; set; }

        bool Status { get; set; }

        T Data { get; set; }
    }
}
