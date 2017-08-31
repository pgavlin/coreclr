using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__dbgvtret__dbgvtret_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__dbgvtret__dbgvtret_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_dbgvtret\\_dbgvtret.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
