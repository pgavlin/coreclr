using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_Roslyn_CscBench_CscBench_
    {
        [Fact]
        public void _CodeQuality_Roslyn_CscBench_CscBench_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Roslyn\\CscBench\\CscBench.cmd");
        }
    }
}
