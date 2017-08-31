using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0308_ToLower_ToLower_
    {
        [OuterLoop]
        [Fact]
        public void _0308_ToLower_ToLower_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0308\\ToLower\\ToLower.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
