using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_dev10_b392262_b392262_b392262_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b392262_b392262_b392262_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b392262\\b392262\\b392262.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
