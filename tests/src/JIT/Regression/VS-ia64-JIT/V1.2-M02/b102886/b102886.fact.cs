using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M02_b102886_b102886_b102886_
    {
        [Fact]
        public void _VS_ia64_JIT_V1_2_M02_b102886_b102886_b102886_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M02\\b102886\\b102886\\b102886.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
