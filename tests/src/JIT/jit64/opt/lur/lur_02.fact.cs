using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_lur_lur_02_lur_02_
    {
        [OuterLoop]
        [Fact]
        public void _opt_lur_lur_02_lur_02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\lur\\lur_02\\lur_02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
