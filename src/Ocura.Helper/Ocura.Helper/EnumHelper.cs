using System;
using System.Collections.Generic;
using System.Linq;

namespace Ocura.Helper
{
  public static class EnumHelper
  {
    /// <summary>
    ///   Gets the values.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static IEnumerable<T> GetValues<T>()
    {
      return Enum.GetValues(typeof(T)).Cast<T>();
    }

    /// <summary>
    ///   Descriptions the specified value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    public static string Description(this Enum value)
    {
      // get attributes  
      var field = value.GetType().GetField(value.ToString());
      var attributes = field.GetCustomAttributes(false);

      // Description is in a hidden Attribute class called DisplayAttribute
      // Not to be confused with DisplayNameAttribute
      dynamic displayAttribute = null;

      if (attributes.Any())
        displayAttribute = attributes.ElementAt(0);

      // return description
      return displayAttribute?.Description ?? value.ToString();
    }

    /// <summary>
    ///   To the int32.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    public static int ToInt32(this Enum value)
    {
      return Convert.ToInt32(value);
    }

    /// <summary>
    ///   Gets the key values.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static IEnumerable<KeyValuePair<string, int>> GetKeyValues<T>()
    {
      var enumValues = GetValues<T>();
      return enumValues
        .Select(enumValue => new KeyValuePair<string, int>(enumValue.ToString(), Convert.ToInt32(enumValue))).ToList();
    }
  }
}
