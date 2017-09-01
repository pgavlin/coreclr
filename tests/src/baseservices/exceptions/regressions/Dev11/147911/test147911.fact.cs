using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_Dev11_147911_test147911_test147911_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _regressions_Dev11_147911_test147911_test147911_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\Dev11\\147911\\test147911\\test147911.cmd");
        }
    }
}
