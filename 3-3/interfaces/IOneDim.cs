﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_4
{
    interface IOneDim : IParent
    {
        int Length { get; }

        int this[int index] { get; set; }
    }
}