using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_volatilestaticfield_volatilestaticfield_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_volatilestaticfield_volatilestaticfield_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\volatilestaticfield\\volatilestaticfield.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
