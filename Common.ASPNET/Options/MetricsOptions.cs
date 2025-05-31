using Microsoft.Extensions.Options;
using OpenShock.Common.ASPNET.Utils;

namespace OpenShock.Common.ASPNET.Options;

public sealed class MetricsOptions
{
    public const string SectionName = "OpenShock:Metrics";

    public IReadOnlyCollection<string> AllowedNetworks { get; init; } = TrustedProxiesFetcher.PrivateNetworks;
}

public class MetricsOptionsValidator : IValidateOptions<MetricsOptions>
{
    public ValidateOptionsResult Validate(string? name, MetricsOptions options)
    {
        var builder = new ValidateOptionsResultBuilder();

        return builder.Build();
    }
}