using Xunit;

namespace Soenneker.Facts.Manual;

/// <summary>
/// An xUnit Fact attribute derivation that when used to decorate a method it skips the test <para/>
/// Replace with [Fact] to run test the test manually.
/// </summary>
public sealed class ManualFactAttribute : FactAttribute
{
    private const string _default = "ManualFact";

    public ManualFactAttribute(string? reason = null)
    {
        Skip = string.IsNullOrEmpty(reason)
            ? _default
            : string.Concat(_default, ":", reason);
    }
}