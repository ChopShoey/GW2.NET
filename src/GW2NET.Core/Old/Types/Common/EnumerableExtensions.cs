﻿// <copyright file="EnumerableExtensions.cs" company="GW2.NET Coding Team">
// This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>

namespace GW2NET.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensions
    {
        public static IDictionaryRange<TKey, TValue> ToDictionaryRange<TKey, TValue>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, int subtotalCount, int totalCount)
        {
            return new DictionaryRange<TKey, TValue>(source.ToDictionary(keySelector))
            {
                SubtotalCount = subtotalCount,
                TotalCount = totalCount
            };
        }

        public static IEnumerable<List<T>> BatchBy<T>(this IEnumerable<T> enumerable, int batchSize)
        {
            using (var enumerator = enumerable.GetEnumerator())
            {
                List<T> list = null;
                while (enumerator.MoveNext())
                {
                    if (list == null)
                    {
                        list = new List<T> { enumerator.Current };
                    }
                    else if (list.Count < batchSize)
                    {
                        list.Add(enumerator.Current);
                    }
                    else
                    {
                        yield return list;
                        list = new List<T> { enumerator.Current };
                    }
                }

                if (list?.Count > 0)
                {
                    yield return list;
                }
            }
        }
    }
}
