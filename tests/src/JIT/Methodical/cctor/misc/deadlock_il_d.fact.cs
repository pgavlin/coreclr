using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_deadlock_il_d_deadlock_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_deadlock_il_d_deadlock_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\deadlock_il_d\\deadlock_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
