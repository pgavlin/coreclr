using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_tryCatchFinallyThrow_nonlocalexit4_r_tryCatchFinallyThrow_nonlocalexit4_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_tryCatchFinallyThrow_nonlocalexit4_r_tryCatchFinallyThrow_nonlocalexit4_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\tryCatchFinallyThrow_nonlocalexit4_r\\tryCatchFinallyThrow_nonlocalexit4_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
