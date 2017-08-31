using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M09_b13170_b13170_b13170_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b13170_b13170_b13170_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b13170\\b13170\\b13170.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
