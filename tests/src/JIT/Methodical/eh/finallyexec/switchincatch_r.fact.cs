using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_finallyexec_switchincatch_r_switchincatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_switchincatch_r_switchincatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\switchincatch_r\\switchincatch_r.cmd");
        }
    }
}
