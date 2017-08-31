using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_vt3_cs_do_vt3_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_vt3_cs_do_vt3_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\vt3_cs_do\\vt3_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
