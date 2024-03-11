namespace XPS.Services.Interfaces;

public interface IRomanNumeralService
{
    string ConvertRoundedUnitToRoman(int decimalUnit);
    string ConvertIntegerToRoman(int integer);
}
