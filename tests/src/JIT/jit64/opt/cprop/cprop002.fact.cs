using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cprop_cprop002_cprop002_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop002_cprop002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop002\\cprop002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
