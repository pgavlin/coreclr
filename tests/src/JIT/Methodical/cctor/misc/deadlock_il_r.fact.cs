using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_deadlock_il_r_deadlock_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_deadlock_il_r_deadlock_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\deadlock_il_r\\deadlock_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
