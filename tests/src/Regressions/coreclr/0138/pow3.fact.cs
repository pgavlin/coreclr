using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0138_pow3_pow3_
    {
        [OuterLoop]
        [Fact]
        public void _0138_pow3_pow3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0138\\pow3\\pow3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
