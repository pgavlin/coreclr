using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__dbgjumps__dbgjumps_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__dbgjumps__dbgjumps_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_dbgjumps\\_dbgjumps.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
