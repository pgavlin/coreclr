using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_tryCatchFinallyThrow_nonlocalexit2_d_tryCatchFinallyThrow_nonlocalexit2_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_tryCatchFinallyThrow_nonlocalexit2_d_tryCatchFinallyThrow_nonlocalexit2_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\tryCatchFinallyThrow_nonlocalexit2_d\\tryCatchFinallyThrow_nonlocalexit2_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
