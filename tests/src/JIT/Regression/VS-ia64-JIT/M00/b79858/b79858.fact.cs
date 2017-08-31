using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b79858_b79858_b79858_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b79858_b79858_b79858_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b79858\\b79858\\b79858.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
