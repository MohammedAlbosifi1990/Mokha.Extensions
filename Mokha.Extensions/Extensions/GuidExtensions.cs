using System;

namespace Mokha.Extensions.Extensions
{
    public static class GuidExtensions
    {
        public static bool IsValid(this string guidString, out Guid? guid)
        {
            guid = null;
            if (string.IsNullOrEmpty(guidString)) return false;
            if (Guid.TryParse(guidString, out var parseGuid) is not true) return false;
            guid = parseGuid;
            return true;
        }
    }
}