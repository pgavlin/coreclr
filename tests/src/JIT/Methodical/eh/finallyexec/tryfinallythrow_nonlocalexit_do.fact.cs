using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_tryfinallythrow_nonlocalexit_do_tryfinallythrow_nonlocalexit_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_tryfinallythrow_nonlocalexit_do_tryfinallythrow_nonlocalexit_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\tryfinallythrow_nonlocalexit_do\\tryfinallythrow_nonlocalexit_do.cmd");
        }
    }
}
