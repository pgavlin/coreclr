using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cprop_cprop001_ro_cprop001_ro_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop001_ro_cprop001_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop001_ro\\cprop001_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
