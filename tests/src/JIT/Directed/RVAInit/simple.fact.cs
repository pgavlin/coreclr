using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _RVAInit_simple_simple_
    {
        [OuterLoop]
        [Fact]
        public void _RVAInit_simple_simple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\simple\\simple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
