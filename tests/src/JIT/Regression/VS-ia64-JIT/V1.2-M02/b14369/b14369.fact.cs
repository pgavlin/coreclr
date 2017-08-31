using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M02_b14369_b14369_b14369_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_V1_2_M02_b14369_b14369_b14369_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M02\\b14369\\b14369\\b14369.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
