using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_tryCatchFinallyThrow_nonlocalexit2_ro_tryCatchFinallyThrow_nonlocalexit2_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_tryCatchFinallyThrow_nonlocalexit2_ro_tryCatchFinallyThrow_nonlocalexit2_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\tryCatchFinallyThrow_nonlocalexit2_ro\\tryCatchFinallyThrow_nonlocalexit2_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
