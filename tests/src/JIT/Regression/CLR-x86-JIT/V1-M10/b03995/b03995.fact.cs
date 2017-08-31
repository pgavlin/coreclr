using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M10_b03995_b03995_b03995_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b03995_b03995_b03995_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b03995\\b03995\\b03995.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
