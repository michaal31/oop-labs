using System;
public static class Validator
{
    public static int Limiter(int value, int min, int max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }

    public static string Shortener(string value, int min, int max, char placeholder)
    {
        if (string.IsNullOrWhiteSpace(value))
            value = new string(placeholder, min);

        value = value.Trim();

        if (value.Length < min)
            value = value.PadRight(min, placeholder);

        if (value.Length > max)
            value = value.Substring(0, max);

        return value;
    }
}
