using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_dev10_b402701_b402701_b402701_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b402701_b402701_b402701_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b402701\\b402701\\b402701.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
