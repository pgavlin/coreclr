using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchF_Trap_Trap_Trap_
    {
        [Fact]
        public void _CodeQuality_BenchF_Trap_Trap_Trap_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchF\\Trap\\Trap\\Trap.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
