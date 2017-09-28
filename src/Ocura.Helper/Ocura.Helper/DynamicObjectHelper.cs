using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Ocura.Helper
{
  public class DynamicObjectHelper
  {
    /// <summary>
    /// Generates the nested object.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    public static dynamic GenerateNestedObject(string key, object value)
    {
      var obj = new ExpandoObject() as IDictionary<string, object>;
      if (key.Contains("."))
      {
        var indexOfDot = key.IndexOf('.');
        var newKey = key.Substring(0, indexOfDot);
        var childKey = key.Substring(indexOfDot + 1, key.Length - indexOfDot - 1);
        obj[newKey] = GenerateNestedObject(childKey, value);
      }
      else
      {
        obj[key] = value;
      }
      return obj;
    }

    /// <summary>
    /// Adds the IDictionary.
    /// </summary>
    /// <param name="objA">The object a.</param>
    /// <param name="objB">The object b.</param>
    /// <returns></returns>
    public static ExpandoObject AddIDictionary(ExpandoObject objA, ExpandoObject objB)
    {
      var dicA = objA as IDictionary<string, object>;
      var dicB = objB as IDictionary<string, object>;

      foreach (var keyValuePair in dicB)
        if (dicA.Any(a => a.Key == keyValuePair.Key))
          dicA[keyValuePair.Key] =
            AddIDictionary((ExpandoObject) dicA[keyValuePair.Key], (ExpandoObject) keyValuePair.Value);
        else
          dicA.Add(keyValuePair.Key, keyValuePair.Value);

      return (ExpandoObject) dicA;
    }
  }
}
