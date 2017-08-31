using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0275_Marshal_Marshal_
    {
        [OuterLoop]
        [Fact]
        public void _0275_Marshal_Marshal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0275\\Marshal\\Marshal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
