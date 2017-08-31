using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0018_ArrayCopy_ArrayCopy_
    {
        [OuterLoop]
        [Fact]
        public void _0018_ArrayCopy_ArrayCopy_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0018\\ArrayCopy\\ArrayCopy.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
