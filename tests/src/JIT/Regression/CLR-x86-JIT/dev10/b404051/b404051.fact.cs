using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_dev10_b404051_b404051_b404051_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b404051_b404051_b404051_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b404051\\b404051\\b404051.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
