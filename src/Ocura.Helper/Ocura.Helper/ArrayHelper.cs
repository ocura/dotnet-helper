using System;

namespace Ocura.Helper
{
  /// <summary>
  ///   Array Helper
  /// </summary>
  public class ArrayHelper
  {
    /// <summary>
    ///   To2s the d array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arrays">The arrays.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException">
    ///   Can not contain null arrays
    ///   or
    ///   Input arrays should have the same length
    /// </exception>
    public static T[,] To2DArray<T>(params T[][] arrays)
    {
      if (arrays == null) throw new ArgumentNullException();
      foreach (var a in arrays)
      {
        if (a == null) throw new ArgumentException("Can not contain null arrays");
        if (a.Length != arrays[0].Length) throw new ArgumentException("Input arrays should have the same length");
      }

      var height = arrays.Length;
      var width = arrays[0].Length;

      var result = new T[width, height];

      for (var i = 0; i < height; i++)
      for (var j = 0; j < width; j++)
        result[i, j] = arrays[i][j];

      return result;
    }
  }
}
