namespace Asteroids.Core
{
    public static class NumberInterpreterExtension
    {
        public static string CutToLiteralNumber(this long value)
        {
            return value switch
            {
                _ when value >= 1000000000 => value / 1000000000 + "B",
                _ when value >= 1000000 => value / 1000000 + "M",
                _ when value >= 1000 => value / 1000 + "K",
                _ when value == 0 => "0",
                _ => "NaN"
            };

        }
        public static string CutToLiteralNumber(this int value)
        {
            return value switch
            {
                _ when value >= 1000000 => value / 1000000 + "M",
                _ when value >= 1000 => value / 1000 + "K",
                _ when value == 0 => "0",
                _ => "NaN"
            };

        }
    }
}
