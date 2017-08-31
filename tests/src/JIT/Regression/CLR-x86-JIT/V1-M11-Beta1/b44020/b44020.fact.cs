using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V1_M11_Beta1_b44020_b44020_b44020_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M11_Beta1_b44020_b44020_b44020_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M11-Beta1\\b44020\\b44020\\b44020.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
