using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_simple_simple_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_simple_simple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\simple\\simple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
