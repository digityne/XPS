namespace XPS.Services.UnitTests.Implementations;

[TestClass]
public class RomanNumeralServiceTests
{
    [DataTestMethod]
    [DataRow(1, "I")]
    [DataRow(2, "II")]
    [DataRow(3, "III")]
    [DataRow(4, "IV")]
    [DataRow(5, "V")]
    [DataRow(6, "VI")]
    [DataRow(7, "VII")]
    [DataRow(8, "VIII")]
    [DataRow(9, "IX")]
    [DataRow(10, "X")]
    [DataRow(20, "XX")]
    [DataRow(30, "XXX")]
    [DataRow(40, "XL")]
    [DataRow(50, "L")]
    [DataRow(60, "LX")]
    [DataRow(70, "LXX")]
    [DataRow(80, "LXXX")]
    [DataRow(90, "XC")]
    [DataRow(100, "C")]
    [DataRow(200, "CC")]
    [DataRow(300, "CCC")]
    [DataRow(400, "CD")]
    [DataRow(500, "D")]
    [DataRow(600, "DC")]
    [DataRow(700, "DCC")]
    [DataRow(800, "DCCC")]
    [DataRow(900, "CM")]
    [DataRow(1000, "M")]
    [DataRow(2000, "MM")]
    [DataRow(3000, "MMM")]
    public void ConvertRoundedUnitToRoman_WhenValidRoundedUnit_ThenExpectedRomanNumeralsReturned()
    {
        
    }
}