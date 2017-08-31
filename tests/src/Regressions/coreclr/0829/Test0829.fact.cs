using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0829_Test0829_Test0829_
    {
        [OuterLoop]
        [Fact]
        public void _0829_Test0829_Test0829_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0829\\Test0829\\Test0829.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
