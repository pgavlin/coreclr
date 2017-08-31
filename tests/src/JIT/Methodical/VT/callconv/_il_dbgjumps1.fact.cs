using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgjumps1__il_dbgjumps1_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_dbgjumps1__il_dbgjumps1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgjumps1\\_il_dbgjumps1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
