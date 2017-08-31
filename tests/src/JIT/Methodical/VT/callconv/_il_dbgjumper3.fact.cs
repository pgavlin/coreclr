using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgjumper3__il_dbgjumper3_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_dbgjumper3__il_dbgjumper3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgjumper3\\_il_dbgjumper3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
