﻿namespace Fanitty.Server.Application.UnitTests.Extensions;

public static class UsernameExtensions
{
    public static string TrimToMaxLenght(this string value, int maxLength)
    {
        return value.Substring(0, Math.Min(value.Length, maxLength));
    }
}
