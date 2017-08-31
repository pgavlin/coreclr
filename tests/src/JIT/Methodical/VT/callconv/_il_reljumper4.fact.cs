using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_reljumper4__il_reljumper4_
    {
        [Fact]
        public void _VT_callconv__il_reljumper4__il_reljumper4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_reljumper4\\_il_reljumper4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
