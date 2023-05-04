using Xunit;
using Amazon.Lambda.TestUtilities;

namespace GetSettings.Tests;

public class SettingsTest
{
    [Fact]
    public void FetchAllFunction()
    {
        var result = Settings.FetchAll(new TestLambdaContext());

        Assert.NotNull(result);
        Assert.True(result.Count > 0);
    }
}