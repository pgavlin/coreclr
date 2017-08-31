using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_nbody_nbody_nbody_
    {
        [Fact]
        public void _CodeQuality_BenchmarksGame_nbody_nbody_nbody_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\nbody\\nbody\\nbody.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
