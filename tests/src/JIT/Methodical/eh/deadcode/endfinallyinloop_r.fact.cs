using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_endfinallyinloop_r_endfinallyinloop_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_endfinallyinloop_r_endfinallyinloop_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\endfinallyinloop_r\\endfinallyinloop_r.cmd");
        }
    }
}
