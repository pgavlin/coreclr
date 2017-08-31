using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cprop_cprop001_d_cprop001_d_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop001_d_cprop001_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop001_d\\cprop001_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
