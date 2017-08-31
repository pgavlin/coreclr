using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Math_Functions_Functions_Functions_
    {
        [Fact]
        public void _CodeQuality_Math_Functions_Functions_Functions_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Math\\Functions\\Functions\\Functions.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
