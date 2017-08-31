using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_sealedmethod_sealedmethod_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_sealedmethod_sealedmethod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\sealedmethod\\sealedmethod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
