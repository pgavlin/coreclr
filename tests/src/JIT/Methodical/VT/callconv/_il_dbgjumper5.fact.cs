using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgjumper5__il_dbgjumper5_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_dbgjumper5__il_dbgjumper5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgjumper5\\_il_dbgjumper5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
