using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgcalli__il_dbgcalli_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_dbgcalli__il_dbgcalli_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgcalli\\_il_dbgcalli.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
