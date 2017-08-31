using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_contravariance_contravariance_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_contravariance_contravariance_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\contravariance\\contravariance.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
