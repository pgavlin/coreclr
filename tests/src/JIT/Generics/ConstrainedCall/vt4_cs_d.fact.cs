using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_vt4_cs_d_vt4_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_vt4_cs_d_vt4_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\vt4_cs_d\\vt4_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
