using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_reljumper3__il_reljumper3_
    {
        [Fact]
        public void _VT_callconv__il_reljumper3__il_reljumper3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_reljumper3\\_il_reljumper3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
