using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_covariance_covariance_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_covariance_covariance_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\covariance\\covariance.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
