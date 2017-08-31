using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__speed_relcall__speed_relcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__speed_relcall__speed_relcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_relcall\\_speed_relcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
