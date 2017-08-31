using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0582_csgen_1_csgen_1_
    {
        [OuterLoop]
        [Fact]
        public void _0582_csgen_1_csgen_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0582\\csgen.1\\csgen.1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
