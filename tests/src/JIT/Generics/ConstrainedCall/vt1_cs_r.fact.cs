using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_vt1_cs_r_vt1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_vt1_cs_r_vt1_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\vt1_cs_r\\vt1_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
