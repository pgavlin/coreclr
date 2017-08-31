using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_overload_overload_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_overload_overload_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\overload\\overload.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
