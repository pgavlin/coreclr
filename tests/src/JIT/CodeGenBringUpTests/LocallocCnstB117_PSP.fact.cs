using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocCnstB117_PSP_LocallocCnstB117_PSP_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocCnstB117_PSP_LocallocCnstB117_PSP_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocCnstB117_PSP\\LocallocCnstB117_PSP.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
