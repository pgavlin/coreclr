using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V1_2_M02_b102518_b102518_b102518_
    {
        [Fact]
        public void _VS_ia64_JIT_V1_2_M02_b102518_b102518_b102518_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V1.2-M02\\b102518\\b102518\\b102518.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
