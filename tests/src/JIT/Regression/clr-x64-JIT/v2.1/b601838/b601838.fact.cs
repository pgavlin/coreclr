using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _clr_x64_JIT_v2_1_b601838_b601838_b601838_
    {
        [OuterLoop]
        [Fact]
        public void _clr_x64_JIT_v2_1_b601838_b601838_b601838_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\clr-x64-JIT\\v2.1\\b601838\\b601838\\b601838.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
