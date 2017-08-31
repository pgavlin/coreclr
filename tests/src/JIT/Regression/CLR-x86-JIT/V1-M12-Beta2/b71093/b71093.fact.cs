using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M12_Beta2_b71093_b71093_b71093_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M12_Beta2_b71093_b71093_b71093_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M12-Beta2\\b71093\\b71093\\b71093.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
