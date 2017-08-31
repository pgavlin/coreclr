using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_tryfinallythrow_nonlocalexit_r_tryfinallythrow_nonlocalexit_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_tryfinallythrow_nonlocalexit_r_tryfinallythrow_nonlocalexit_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\tryfinallythrow_nonlocalexit_r\\tryfinallythrow_nonlocalexit_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
