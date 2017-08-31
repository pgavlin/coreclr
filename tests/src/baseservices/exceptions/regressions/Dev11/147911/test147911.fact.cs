using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_Dev11_147911_test147911_test147911_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _regressions_Dev11_147911_test147911_test147911_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\Dev11\\147911\\test147911\\test147911.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
