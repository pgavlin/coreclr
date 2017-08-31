using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__dbghan3_ref__dbghan3_ref_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__dbghan3_ref__dbghan3_ref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_dbghan3_ref\\_dbghan3_ref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
