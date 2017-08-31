using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0570_Test570_Test570_
    {
        [OuterLoop]
        [Fact]
        public void _0570_Test570_Test570_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0570\\Test570\\Test570.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
