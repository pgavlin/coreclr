using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_endfinallyinloop_d_endfinallyinloop_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_endfinallyinloop_d_endfinallyinloop_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\endfinallyinloop_d\\endfinallyinloop_d.cmd");
        }
    }
}
