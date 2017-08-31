using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M12_Beta2_b70909_b70909_b70909_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M12_Beta2_b70909_b70909_b70909_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M12-Beta2\\b70909\\b70909\\b70909.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
