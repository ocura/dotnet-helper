using System;
using System.Collections.Generic;
using System.Linq;

namespace Ocura.Helper
{
  public static class LinqHelper
  {
    /// <summary>
    ///   Pages the specified page.
    /// </summary>
    /// <typeparam name="TSource">The type of the source.</typeparam>
    /// <param name="source">The source.</param>
    /// <param name="page">The page.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <returns></returns>
    public static IQueryable<TSource> Page<TSource>(this IQueryable<TSource> source, int page, int pageSize)
    {
      return source.Skip((page - 1) * pageSize).Take(pageSize);
    }

    /// <summary>
    ///   Pages the specified page.
    /// </summary>
    /// <typeparam name="TSource">The type of the source.</typeparam>
    /// <param name="source">The source.</param>
    /// <param name="page">The page.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <returns></returns>
    public static IEnumerable<TSource> Page<TSource>(this IEnumerable<TSource> source, int page, int pageSize)
    {
      return source.Skip((page - 1) * pageSize).Take(pageSize);
    }

    /// <summary>
    ///   Concats the specified delimiter.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="delimiter">The delimiter.</param>
    /// <returns></returns>
    public static string Concat(this IEnumerable<long> source, string delimiter)
    {
      IEnumerable<long> enumerable = source as long[] ?? source.ToArray();
      return !enumerable.Any()
        ? string.Empty
        : enumerable.Select(a => a.ToString()).Aggregate((i, j) => $"{i}{delimiter}{j}");
    }

    /// <summary>
    ///   Combines with.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="first">The first.</param>
    /// <param name="second">The second.</param>
    /// <returns></returns>
    public static IEnumerable<Tuple<T, T>> CombineWith<T>(this IEnumerable<T> first, IEnumerable<T> second)
    {
      using (var firstEnumerator = first.GetEnumerator())
      using (var secondEnumerator = second.GetEnumerator())
      {
        var hasFirst = true;
        var hasSecond = true;

        while ((hasFirst && (hasFirst = firstEnumerator.MoveNext())) |
               (hasSecond && (hasSecond = secondEnumerator.MoveNext())))
          yield return Tuple.Create(
            hasFirst ? firstEnumerator.Current : default(T),
            hasSecond ? secondEnumerator.Current : default(T)
          );
      }
    }
  }
}
