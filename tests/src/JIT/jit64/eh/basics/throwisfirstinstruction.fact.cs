using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_basics_throwisfirstinstruction_throwisfirstinstruction_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwisfirstinstruction_throwisfirstinstruction_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\basics\\throwisfirstinstruction\\throwisfirstinstruction.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
