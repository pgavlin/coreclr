using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_generic_generic_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_generic_generic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\generic\\generic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
