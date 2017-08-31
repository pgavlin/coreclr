using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cprop_cprop001_r_cprop001_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop001_r_cprop001_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop001_r\\cprop001_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
