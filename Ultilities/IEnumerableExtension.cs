﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ultilities
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> Safe<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                yield break;
            }

            foreach (var item in source)
            {
                yield return item;
            }
        }
    }
}
