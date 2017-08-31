using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cprop_cprop001_do_cprop001_do_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop001_do_cprop001_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop001_do\\cprop001_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
