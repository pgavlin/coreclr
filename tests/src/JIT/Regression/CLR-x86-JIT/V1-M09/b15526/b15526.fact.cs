using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M09_b15526_b15526_b15526_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_b15526_b15526_b15526_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09\\b15526\\b15526\\b15526.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
