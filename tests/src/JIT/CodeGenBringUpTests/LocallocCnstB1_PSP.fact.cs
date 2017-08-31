using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocCnstB1_PSP_LocallocCnstB1_PSP_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocCnstB1_PSP_LocallocCnstB1_PSP_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocCnstB1_PSP\\LocallocCnstB1_PSP.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
