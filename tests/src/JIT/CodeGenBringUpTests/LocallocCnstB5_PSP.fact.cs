using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocCnstB5_PSP_LocallocCnstB5_PSP_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocCnstB5_PSP_LocallocCnstB5_PSP_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocCnstB5_PSP\\LocallocCnstB5_PSP.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
