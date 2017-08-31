using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_tryfinallythrow_nonlocalexit_ro_tryfinallythrow_nonlocalexit_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_tryfinallythrow_nonlocalexit_ro_tryfinallythrow_nonlocalexit_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\tryfinallythrow_nonlocalexit_ro\\tryfinallythrow_nonlocalexit_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
