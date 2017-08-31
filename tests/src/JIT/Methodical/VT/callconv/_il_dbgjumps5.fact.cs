using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgjumps5__il_dbgjumps5_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_dbgjumps5__il_dbgjumps5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgjumps5\\_il_dbgjumps5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
