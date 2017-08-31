using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__il_dbgvolatile__il_dbgvolatile_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__il_dbgvolatile__il_dbgvolatile_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_il_dbgvolatile\\_il_dbgvolatile.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
