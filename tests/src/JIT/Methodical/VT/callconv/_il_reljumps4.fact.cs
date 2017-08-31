using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_reljumps4__il_reljumps4_
    {
        [Fact]
        public void _VT_callconv__il_reljumps4__il_reljumps4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_reljumps4\\_il_reljumps4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
