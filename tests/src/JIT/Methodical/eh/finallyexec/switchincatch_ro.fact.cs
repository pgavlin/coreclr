using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_switchincatch_ro_switchincatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_switchincatch_ro_switchincatch_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\switchincatch_ro\\switchincatch_ro.cmd");
        }
    }
}
