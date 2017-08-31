using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__speed_reljumper__speed_reljumper_
    {
        [Fact]
        public void _VT_callconv__speed_reljumper__speed_reljumper_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_reljumper\\_speed_reljumper.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
