using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0202_ThreadCulture_ThreadCulture_
    {
        [OuterLoop]
        [Fact]
        public void _0202_ThreadCulture_ThreadCulture_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0202\\ThreadCulture\\ThreadCulture.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
