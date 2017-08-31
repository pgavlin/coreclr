using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__reljumps__reljumps_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__reljumps__reljumps_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_reljumps\\_reljumps.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
