﻿using System;
using System.Collections.Generic;

namespace StackOverflowTagServer
{
    public static class Extensions
    {
        public static bool ListEquals<T>(this IList<T> list1, IList<T> list2, Func<T, T, bool> comparer)
        {
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                //if (!list1[i].Equals(list2[i]))
                if (comparer(list1[i], list2[i]) == false)
                    return false;
            }
            return true;
        }
    }
}