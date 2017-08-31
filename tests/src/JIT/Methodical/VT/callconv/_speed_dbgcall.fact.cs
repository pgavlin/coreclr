using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__speed_dbgcall__speed_dbgcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__speed_dbgcall__speed_dbgcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_dbgcall\\_speed_dbgcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
