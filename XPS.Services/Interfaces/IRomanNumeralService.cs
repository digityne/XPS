namespace XPS.Services.Interfaces;

public interface IRomanNumeralService
{
    string ConvertRoundUnitToRoman(int decimalUnit);
    string ConvertIntegerToRoman(int integer);
}
