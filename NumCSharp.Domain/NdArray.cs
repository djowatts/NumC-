using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NumCSharp.Domain
{
    public static class NdArray<T> where T : IComparable<T>, new()
    {
        public static Array OfZeros(int rows, int columns)
        {
            if (rows == 1)
            {
                return new T[columns];
            }
            return new T[rows, columns];
        }
    }
}
