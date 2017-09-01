using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_callconv__speed_reljumps__speed_reljumps_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__speed_reljumps__speed_reljumps_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_reljumps\\_speed_reljumps.cmd");
        }
    }
}
