namespace OpenShock.Common.ASPNET.Utils;

public static class AuthUtils
{
    private static CookieOptions GetCookieOptions(string domain, TimeSpan lifetime)
    {
        return new CookieOptions
        {
            Expires = new DateTimeOffset(DateTime.UtcNow.Add(lifetime)),
            Secure = true,
            HttpOnly = true,
            SameSite = SameSiteMode.Strict,
            Domain = domain
        };
    }
}
