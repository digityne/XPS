using Microsoft.Extensions.DependencyInjection;
using XPS.Services.Implementations;
using XPS.Services.Interfaces;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IRomanNumeralService, RomanNumeralService>()
    .BuildServiceProvider();

var romanNumeralService = serviceProvider.GetService<IRomanNumeralService>() ?? throw new InvalidOperationException($"{nameof(IRomanNumeralService)} needs to be available in the service collection");

string? lastInput = string.Empty;

Console.WriteLine("At any point, write EXIT to exit the console app");

while (!string.Equals(lastInput, "EXIT", StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("Please enter a digit from 1 to 2000: ");

    lastInput = Console.ReadLine();

    if (romanNumeralService.EnsureInputStringIsValid(lastInput))
    {
        Console.WriteLine($"{lastInput} in Roman Numerals is: {romanNumeralService.ConvertIntegerToRoman(int.Parse(lastInput!))}");
    }
}
