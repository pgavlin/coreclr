using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__relcall__relcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__relcall__relcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_relcall\\_relcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
