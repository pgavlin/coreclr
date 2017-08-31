using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__speed_dbgjumps__speed_dbgjumps_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__speed_dbgjumps__speed_dbgjumps_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_dbgjumps\\_speed_dbgjumps.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
