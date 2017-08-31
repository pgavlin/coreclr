using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M10_b04538_b04538_b04538_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b04538_b04538_b04538_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b04538\\b04538\\b04538.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
