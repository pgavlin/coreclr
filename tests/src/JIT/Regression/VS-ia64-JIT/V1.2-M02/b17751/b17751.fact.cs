using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M02_b17751_b17751_b17751_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V1_2_M02_b17751_b17751_b17751_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M02\\b17751\\b17751\\b17751.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
