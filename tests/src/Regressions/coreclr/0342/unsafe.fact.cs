using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0342_unsafe_unsafe_
    {
        [OuterLoop]
        [Fact]
        public void _0342_unsafe_unsafe_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0342\\unsafe\\unsafe.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
