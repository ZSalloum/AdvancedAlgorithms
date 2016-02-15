﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algorithms.Toolkit.Common;

namespace Algorithms.Toolkit.DataStructures
{
    public class MaxHeap<T> : BaseHeap<T>
                where T : IComparable
    {

        protected override bool Compare(T a, T b)
        {
            return Less(a, b);
        }
    }
}
