using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b85566_b85566_b85566_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b85566_b85566_b85566_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b85566\\b85566\\b85566.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
