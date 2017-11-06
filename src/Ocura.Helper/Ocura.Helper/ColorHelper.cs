using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ocura.Helper
{
  /// <summary>
  /// Color Helper
  /// </summary>
  public static class ColorHelper
  {
    /// <summary>
    /// To the RGB.
    /// </summary>
    /// <param name="rgba">The rgba.</param>
    /// <returns></returns>
    public static Color ToRGB(this Color rgba)
    {
      var background = Color.White;

      var alpha = rgba.A / 255M;
      return Color.FromArgb(
        ((1 - alpha) * background.R + alpha * rgba.R).RoundUp(),
        ((1 - alpha) * background.G + alpha * rgba.G).RoundUp(),
        ((1 - alpha) * background.B + alpha * rgba.B).RoundUp()
      );
    }

    /// <summary>
    /// To the RGB string.
    /// </summary>
    /// <param name="rgba">The rgba.</param>
    /// <returns></returns>
    public static string ToRGBString(this Color rgba)
    {
      var color = rgba.ToRGB();
      return $"rgb({color.R}, {color.G}, {color.B})";
    }
  }
}
