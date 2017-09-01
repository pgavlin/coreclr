using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_contravariance_contravariance_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_contravariance_contravariance_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\contravariance\\contravariance.cmd");
        }
    }
}
