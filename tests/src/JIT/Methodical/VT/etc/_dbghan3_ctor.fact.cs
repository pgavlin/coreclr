using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__dbghan3_ctor__dbghan3_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__dbghan3_ctor__dbghan3_ctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_dbghan3_ctor\\_dbghan3_ctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
