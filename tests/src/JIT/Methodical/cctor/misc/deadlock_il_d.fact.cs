using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_deadlock_il_d_deadlock_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_deadlock_il_d_deadlock_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\deadlock_il_d\\deadlock_il_d.cmd");
        }
    }
}
