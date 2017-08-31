using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_tryfinallythrow_nonlocalexit_d_tryfinallythrow_nonlocalexit_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_tryfinallythrow_nonlocalexit_d_tryfinallythrow_nonlocalexit_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\tryfinallythrow_nonlocalexit_d\\tryfinallythrow_nonlocalexit_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
