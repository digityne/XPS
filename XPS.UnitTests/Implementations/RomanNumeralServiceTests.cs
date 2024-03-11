using XPS.Services.Implementations;

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
    public void ConvertRoundedUnitToRoman_WhenValidRoundedUnit_ThenExpectedRomanNumeralsReturned(int input, string expectedOutput)
    {
        var romanNumeralService = new RomanNumeralService();

        var actualResult = romanNumeralService.ConvertRoundUnitToRoman(input);

        Assert.AreEqual(expectedOutput, actualResult);
    }

    [DataTestMethod]
    [DataRow(11)]
    [DataRow(201)]
    [DataRow(999)]
    [DataRow(1001)]
    public void ConvertRoundedUnitToRoman_WhenNotOneSigFigNumber_ThenExpectArgumentExceptionThrown(int input)
    {
        var romanNumeralService = new RomanNumeralService();

        Action action = () => romanNumeralService.ConvertRoundUnitToRoman(input);

        Assert.ThrowsException<ArgumentException>(action);
    }

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(-1)]
    [DataRow(2000)]
    public void ConvertRoundedUnitToRoman_WhenInvalidInteger_ThenExpectArgumentOutOfRangeExceptionThrown(int input)
    {
        var romanNumeralService = new RomanNumeralService();

        Action action = () => romanNumeralService.ConvertRoundUnitToRoman(input);

        Assert.ThrowsException<ArgumentOutOfRangeException>(action);
    }

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
    [DataRow(11, "XI")]
    [DataRow(12, "XII")]
    [DataRow(13, "XIII")]
    [DataRow(14, "XIV")]
    [DataRow(15, "XV")]
    [DataRow(16, "XVI")]
    [DataRow(17, "XVII")]
    [DataRow(18, "XVIII")]
    [DataRow(19, "XIX")]
    [DataRow(20, "XX")]
    [DataRow(49, "XLIX")]
    [DataRow(50, "L")]
    [DataRow(51, "LI")]
    [DataRow(99, "XCIX")]
    [DataRow(100, "C")]
    [DataRow(101, "CI")]
    [DataRow(777, "DCCLXXVII")]
    [DataRow(999, "CMXCIX")]
    [DataRow(1001, "MI")]
    [DataRow(1234, "MCCXXXIV")]
    [DataRow(1982, "MCMLXXXII")]
    [DataRow(2000, "MM")]
    public void ConvertIntegerToRoman_WhenValidInteger_ThenExpectedRomanNumeralReturned(int input, string expectedOutput)
    {
        var romanNumeralService = new RomanNumeralService();

        var actualResult = romanNumeralService.ConvertIntegerToRoman(input);

        Assert.AreEqual(expectedOutput, actualResult);
    }

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(-1)]
    [DataRow(2001)]
    public void ConvertIntegerToRoman_WhenInValidInteger_ThenExpectArgumentOutOfRangeErrorThrown(int input)
    {
        var romanNumeralService = new RomanNumeralService();

        Action action = () => romanNumeralService.ConvertIntegerToRoman(input);

        Assert.ThrowsException<ArgumentOutOfRangeException>(action);
    }
}