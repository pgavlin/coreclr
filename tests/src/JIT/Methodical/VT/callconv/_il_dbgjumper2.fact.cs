using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__il_dbgjumper2__il_dbgjumper2_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__il_dbgjumper2__il_dbgjumper2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_il_dbgjumper2\\_il_dbgjumper2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
