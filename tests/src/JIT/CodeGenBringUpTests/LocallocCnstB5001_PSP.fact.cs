using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocCnstB5001_PSP_LocallocCnstB5001_PSP_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocCnstB5001_PSP_LocallocCnstB5001_PSP_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocCnstB5001_PSP\\LocallocCnstB5001_PSP.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
