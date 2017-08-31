using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgjumper1__il_dbgjumper1_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_dbgjumper1__il_dbgjumper1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgjumper1\\_il_dbgjumper1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
