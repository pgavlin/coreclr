using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_covariance_covariance_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_covariance_covariance_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\covariance\\covariance.cmd");
        }
    }
}
