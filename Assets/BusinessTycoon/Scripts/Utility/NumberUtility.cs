using System;
using System.Collections.Generic;

public class NumberUtility
{
    public static string Convert(double number, double largestNumber = 1E+15, bool useDecimals = true, int numberOfDecimals = 2)
    {
        if (number < largestNumber)
        {
            if (useDecimals && number > 0.0f)
            {
                if (number < 0.1f)
                {
                    return number.ToString("N3");
                }
                return number.ToString("N2");
            }
            return number.ToString("N0");
        }

        var raw = Math.Round(number).ToString("F0");
        return GetNumberString(raw, useDecimals, numberOfDecimals);
    }

    private static string GetNumberString(string numberInTextFormat, bool useDecimals = true, int numberOfDecimals = 2)
    {
        if (numberInTextFormat == "Infinity")
        {
            numberInTextFormat = double.MaxValue.ToString();
        }
        string text;
        var postFix = GetTypeNameSuffix(numberInTextFormat, out var startIndex, out var endIndex);
        var num2 = endIndex;
        if (useDecimals && numberOfDecimals > 0)
        {
            num2 = endIndex - numberOfDecimals;
            text = numberInTextFormat.Insert(startIndex, ".");
        }
        else
        {
            text = numberInTextFormat;
        }
        try
        {
            text = text.Remove(text.Length - num2);
            if (text.Contains("."))
            {
                text = text.TrimEnd(new char[] { '.' });
            }

            text = text + " " + postFix;
        }
        catch (ArgumentOutOfRangeException)
        {
            text = "Infinity";
        }
        return text;
    }

    private static string GetTypeNameSuffix(string raw, out int startIndex, out int endIndex)
    {
        var num = raw.Length % 3;
        startIndex = ((num != 0) ? num : 3);
        endIndex = raw.Length - startIndex;
        string result;
        if (endIndex <= 306)
        {
            result = TypeNameSuffix[endIndex];
        }
        else
        {
            result = "BIG NUMBER";
        }
        return result;
    }

    private static readonly Dictionary<int, string> TypeNameSuffix = new Dictionary<int, string>
    {
        {3, "тысяч"},
        {6, "миллион"},
        {9, "миллиард"},
        {12, "триллион"},
        {15, "квантилион"},
        {18, "квинтилион"},
        {21, "сикстилион"},
        {24, "септилион"},
        {27, "октилион"},
        {30, "нонилион"},
        {33, "декилион"},
        {36, "андекилион"},
        {39, "дуодикилион"},
        {42, "tredecillion"},
        {45, "quattuordecillion"},
        {48, "quindecillion"},
        {51, "sexdecillion"},
        {54, "septendecillion"},
        {57, "octodecillion"},
        {60, "novemdecillion"},
        {63, "vigintillion"},
        {66, "unvigintillion"},
        {69, "duovigintillion"},
        {72, "tresvigintillion"},
        {75, "quattuorvigintillion"},
        {78, "quinvigintillion"},
        {81, "sexvigintillion"},
        {84, "septenvigintillion"},
        {87, "octovigintillion"},
        {90, "novemvigintillion"},
        {93, "trigintillion"},
        {96, "untrigintillion"},
        {99, "duotrigintillion"},
        {102, "tretrigintillion"},
        {105, "quattuortrigintillion"},
        {108, "quintrigintillion"},
        {111, "sextrigintillion"},
        {114, "septentrigintillion"},
        {117, "octotrigintillion"},
        {120, "novemtrigintillion"},
        {123, "quadragintillion"},
        {126, "unquadragintillion"},
        {129, "duoquadragintillion"},
        {132, "trequadragintillion"},
        {135, "quattuorquadragintillion"},
        {138, "quinquadragintillion"},
        {141, "sexquadragintillion"},
        {144, "septquadragintillion"},
        {147, "octoquadragintillion"},
        {150, "novemquadragintillion"},
        {153, "quinquagintillion"},
        {156, "unquinquagintillion"},
        {159, "duoquinquagintillion"},
        {162, "trequinquagintillion"},
        {165, "quattuorquinquagintillion"},
        {168, "quinquinquagintillion"},
        {171, "sexquinquagintillion"},
        {174, "septquinquagintillion"},
        {177, "octoquinquagintillion"},
        {180, "novemquinquagintillion"},
        {183, "sexagintillion"},
        {186, "unsexagintillion"},
        {189, "duosexagintillion"},
        {192, "tresexagintillion"},
        {195, "quattuorsexagintillion"},
        {198, "quinsexagintillion"},
        {201, "sexsexagintillion"},
        {204, "septsexagintillion"},
        {207, "octosexagintillion"},
        {210, "novemsexagintillion"},
        {213, "septuagintillion"},
        {216, "unseptuagintillion"},
        {219, "duoseptuagintillion"},
        {222, "treseptuagintillion"},
        {225, "quattuorseptuagintillion"},
        {228, "quinseptuagintillion"},
        {231, "sexseptuagintillion"},
        {234, "septseptuagintillion"},
        {237, "octoseptuagintillion"},
        {240, "novemseptuagintillion"},
        {243, "octogintillion"},
        {246, "unoctogintillion"},
        {249, "duooctogintillion"},
        {252, "treoctogintillion"},
        {255, "quattuoroctogintillion"},
        {258, "quinoctogintillion"},
        {261, "sexoctogintillion"},
        {264, "septoctogintillion"},
        {267, "octooctogintillion"},
        {270, "novemoctogintillion"},
        {273, "nonagintillion"},
        {276, "unnonagintillion"},
        {279, "duononagintillion"},
        {282, "trenonagintillion"},
        {285, "quattuornonagintillion"},
        {288, "quinnonagintillion"},
        {291, "sexnonagintillion"},
        {294, "septnonagintillion"},
        {297, "octononagintillion"},
        {300, "novemnonagintillion"},
        {303, "centillion"},
        {306, "uncentillion"}
    };
}