using XPS.Services.Interfaces;
using XPS.Common.Extensions;

namespace XPS.Services.Implementations;

public class RomanNumeralService : IRomanNumeralService
{
    public string ConvertIntegerToRoman(int integer)
    {
        // TODO: Improvement - break out the validation so we don't need to convert back to string
        if (!EnsureInputStringIsValid(integer.ToString()))
        {
            // TODO: Message in exception
            throw new ArgumentException();
        }

        return string.Join("", integer.ToDecimalUnitsArray().OrderByDescending(x => x).Select(ConvertRoundUnitToRoman));
    }

    public string ConvertRoundUnitToRoman(int roundedUnit)
    {
        // TODO: Improvement - break out the validation so we don't need to convert back to string
        if (!EnsureInputStringIsValid(roundedUnit.ToString()))
        {
            // TODO: Message in exception
            throw new ArgumentException();
        }

        if (!roundedUnit.HasOneSignificantFigure())
        {
            throw new ArgumentException($"Only integers with more one significant figure should be passed to {nameof(ConvertRoundUnitToRoman)} - actual {roundedUnit}");
        }

        string roundedUnitString = roundedUnit.ToString();

        int intLength = roundedUnitString.Length;
        int intUnit = int.Parse(roundedUnitString[..1]);

        // TODO: Improvement - this should be a separate method with unit test
        string template = intUnit < 4 ? new string('I', intUnit) :
            intUnit == 4 ? "IV" :
            intUnit == 5 ? "V" :
            intUnit < 9 ? "V" + new string('I', intUnit - 5) :
            "IX";

        // TODO: Improvement - this is primed to be a cyclical set of replacements based on int length
        // This would also ensure more dynamic / scalable by adding higher roman numberals in a less manual way
        return intLength == 1 ? template :
            intLength == 2 ? template.Replace('X', 'C').Replace('V', 'L').Replace('I', 'X') :
            intLength == 3 ? template.Replace('X', 'M').Replace('V', 'D').Replace('I', 'C') :
            template.Replace("X", "").Replace("V", "").Replace('I', 'M');
    }

    public bool EnsureInputStringIsValid(string? inputStr)
    {
        if (string.IsNullOrEmpty(inputStr)) return false;
        if (!int.TryParse(inputStr, out int integer)) return false;
        if (integer < 1 || integer > 2000) return false;

        return true;
    }
}
