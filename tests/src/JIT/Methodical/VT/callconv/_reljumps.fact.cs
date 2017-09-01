using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_callconv__reljumps__reljumps_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__reljumps__reljumps_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_reljumps\\_reljumps.cmd");
        }
    }
}
