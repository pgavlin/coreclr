using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_BenchI_Pi_Pi_Pi_
    {
        [Fact]
        public void _CodeQuality_BenchI_Pi_Pi_Pi_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\Pi\\Pi\\Pi.cmd");
        }
    }
}
