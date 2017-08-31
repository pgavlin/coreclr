using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_Desktop_prefldinit3_il_r_prefldinit3_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_Desktop_prefldinit3_il_r_prefldinit3_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\Desktop\\prefldinit3_il_r\\prefldinit3_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
