using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b80737_b80737_b80737_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b80737_b80737_b80737_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b80737\\b80737\\b80737.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
