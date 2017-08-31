using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M02_b14366_b14366_b14366_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V1_2_M02_b14366_b14366_b14366_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M02\\b14366\\b14366\\b14366.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
