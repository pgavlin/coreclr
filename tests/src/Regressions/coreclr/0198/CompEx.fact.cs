using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0198_CompEx_CompEx_
    {
        [OuterLoop]
        [Fact]
        public void _0198_CompEx_CompEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0198\\CompEx\\CompEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
