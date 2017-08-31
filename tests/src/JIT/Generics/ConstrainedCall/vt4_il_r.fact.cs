using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_vt4_il_r_vt4_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_vt4_il_r_vt4_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\vt4_il_r\\vt4_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
