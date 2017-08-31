using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0041_expl_double_1_expl_double_1_
    {
        [OuterLoop]
        [Fact]
        public void _0041_expl_double_1_expl_double_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0041\\expl_double_1\\expl_double_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
