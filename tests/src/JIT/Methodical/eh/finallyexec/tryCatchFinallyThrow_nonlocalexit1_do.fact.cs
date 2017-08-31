using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_tryCatchFinallyThrow_nonlocalexit1_do_tryCatchFinallyThrow_nonlocalexit1_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_tryCatchFinallyThrow_nonlocalexit1_do_tryCatchFinallyThrow_nonlocalexit1_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\tryCatchFinallyThrow_nonlocalexit1_do\\tryCatchFinallyThrow_nonlocalexit1_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
