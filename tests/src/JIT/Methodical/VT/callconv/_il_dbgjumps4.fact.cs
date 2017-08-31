using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgjumps4__il_dbgjumps4_
    {
        [Fact]
        public void _VT_callconv__il_dbgjumps4__il_dbgjumps4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgjumps4\\_il_dbgjumps4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
