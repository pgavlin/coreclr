using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b85314_b85314_b85314_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b85314_b85314_b85314_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b85314\\b85314\\b85314.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
