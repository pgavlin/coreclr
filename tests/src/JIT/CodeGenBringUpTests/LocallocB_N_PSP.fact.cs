using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocB_N_PSP_LocallocB_N_PSP_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocB_N_PSP_LocallocB_N_PSP_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocB_N_PSP\\LocallocB_N_PSP.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
