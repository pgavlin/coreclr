using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b92726_b92726_b92726_
    {
        [Fact]
        public void _VS_ia64_JIT_M00_b92726_b92726_b92726_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b92726\\b92726\\b92726.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
