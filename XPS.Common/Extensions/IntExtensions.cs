namespace XPS.Common.Extensions;

public static class IntExtensions
{
    public static int[] ToDecimalUnitsArray(this int i)
    {
        var result = new List<int>();
        int decimalMultiplier = 1;

        while (i > 0)
        {
            var lastNumber = i % 10;

            if (lastNumber != 0)
            {
                result.Add(lastNumber * decimalMultiplier);
            }

            i /= 10;

            decimalMultiplier *= 10;
        }

        return [.. result];
    }
}
