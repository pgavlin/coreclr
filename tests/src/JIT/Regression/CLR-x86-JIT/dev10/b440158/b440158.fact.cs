using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_dev10_b440158_b440158_b440158_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b440158_b440158_b440158_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b440158\\b440158\\b440158.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
