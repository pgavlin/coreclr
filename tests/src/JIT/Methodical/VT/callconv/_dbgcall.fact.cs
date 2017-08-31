using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__dbgcall__dbgcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__dbgcall__dbgcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_dbgcall\\_dbgcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
