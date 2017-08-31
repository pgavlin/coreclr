using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_b610750_b610750_b610750_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_1_b610750_b610750_b610750_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\b610750\\b610750\\b610750.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
