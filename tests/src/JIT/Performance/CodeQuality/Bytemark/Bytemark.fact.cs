using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Bytemark_Bytemark_Bytemark_
    {
        [Fact]
        public void _CodeQuality_Bytemark_Bytemark_Bytemark_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Bytemark\\Bytemark\\Bytemark.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
