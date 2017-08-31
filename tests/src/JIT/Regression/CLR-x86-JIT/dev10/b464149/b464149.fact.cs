using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_dev10_b464149_b464149_b464149_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b464149_b464149_b464149_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b464149\\b464149\\b464149.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
