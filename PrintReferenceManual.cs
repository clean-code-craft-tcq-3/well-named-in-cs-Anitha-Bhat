using System;

namespace TelCo.ColorCoder
{
  internal class PrintReferenceManual
  {
    internal static void ShowReferenceManual()
    {

      Console.WriteLine("*******************Reference Manual********************");
      Console.WriteLine("\n");

      int totalPair = ColorValues.colorMapMajor.Length * ColorValues.colorMapMinor.Length;

      for (int i = 0; i < totalPair; i++)
      {
        ColorPair pair = EvenCountColorCode.GetColorFromPairNumber(i+1);

        Console.WriteLine(
          String.Format("Pair Number - {0},Major Color - {1}, Minor Color - {2}", i+1, pair.majorColor.Name, pair.minorColor.Name)
        );
        Console.WriteLine("\n");

      }

    }

  }
}

