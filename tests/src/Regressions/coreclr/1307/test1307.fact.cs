using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1307_test1307_test1307_
    {
        [OuterLoop]
        [Fact]
        public void _1307_test1307_test1307_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1307\\test1307\\test1307.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
