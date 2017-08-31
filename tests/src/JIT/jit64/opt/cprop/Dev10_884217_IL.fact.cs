using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cprop_Dev10_884217_IL_Dev10_884217_IL_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_Dev10_884217_IL_Dev10_884217_IL_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\Dev10_884217_IL\\Dev10_884217_IL.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
