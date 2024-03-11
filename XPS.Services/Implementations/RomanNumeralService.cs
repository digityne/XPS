using XPS.Services.Interfaces;
using XPS.Common.Extensions;

namespace XPS.Services.Implementations;

public class RomanNumeralService : IRomanNumeralService
{
    public string ConvertIntegerToRoman(int integer)
    {
        throw new NotImplementedException();
    }

    public string ConvertRoundUnitToRoman(int roundedUnit)
    {
        if (!roundedUnit.HasOneSignificantFigure())
        {
            throw new ArgumentException($"Only integers with more one significant figure should be passed to {nameof(ConvertRoundUnitToRoman)} - actual {roundedUnit}");
        }

        string roundedUnitString = roundedUnit.ToString();

        int intLength = roundedUnitString.Length;
        int intUnit = int.Parse(roundedUnitString[..1]);

        string template = intUnit < 4 ? new string('I', intUnit) :
            intUnit == 4 ? "IV" :
            intUnit == 5 ? "V" :
            intUnit < 9 ? "V" + new string('I', intUnit - 5) :
            "IX";

        return intLength == 1 ? template :
            intLength == 2 ? template.Replace('X', 'C').Replace('V', 'L').Replace('I', 'X') :
            intLength == 3 ? template.Replace('X', 'M').Replace('V', 'D').Replace('I', 'C') :
            template.Replace("X", "").Replace("V", "").Replace('I', 'M');

        // If this were to go higher this would probably best fit a collection of mappings to apply dynamically 
    }
}
