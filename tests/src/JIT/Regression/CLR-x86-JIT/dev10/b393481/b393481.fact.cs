using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_dev10_b393481_b393481_b393481_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b393481_b393481_b393481_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b393481\\b393481\\b393481.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
