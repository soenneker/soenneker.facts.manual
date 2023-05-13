using Xunit;

namespace Soenneker.Facts.Manual;

/// <summary>
/// An xUnit Fact attribute derivation that when used to decorate a method it skips the test <para/>
/// Replace with [Fact] to run test the test manually.
/// </summary>
public class ManualFactAttribute : FactAttribute
{
    private const string _default = "ManualFact";

    public string? Reason { get; set; }

    public override string Skip
    {
        get
        {
            if (Reason != null)
                return $"{_default}:{Reason}";

            return _default;
        }
    }
}