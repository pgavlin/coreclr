using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_vt4_cs_ro_vt4_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_vt4_cs_ro_vt4_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\vt4_cs_ro\\vt4_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
