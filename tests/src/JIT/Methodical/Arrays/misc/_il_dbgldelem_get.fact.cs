using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_dbgldelem_get__il_dbgldelem_get_
    {
        [Fact]
        public void _Arrays_misc__il_dbgldelem_get__il_dbgldelem_get_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_dbgldelem_get\\_il_dbgldelem_get.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
