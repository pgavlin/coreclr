using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgjumper4__il_dbgjumper4_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_dbgjumper4__il_dbgjumper4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgjumper4\\_il_dbgjumper4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
