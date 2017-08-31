using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_reljumps1__il_reljumps1_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_reljumps1__il_reljumps1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_reljumps1\\_il_reljumps1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
