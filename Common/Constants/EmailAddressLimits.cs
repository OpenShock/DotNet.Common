namespace OpenShock.Common.Constants;

public static class EmailAddressLimits
{
    public const int MinLength = 5; // "a@b.c" (5 chars)
    public const int MaxLength = 320; // 64 + 1 + 255 (RFC 2821)
}
