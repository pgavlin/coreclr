using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M10_b04345_B04345_B04345_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b04345_B04345_B04345_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b04345\\B04345\\B04345.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
