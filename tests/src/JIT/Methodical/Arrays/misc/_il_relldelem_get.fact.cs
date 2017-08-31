using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_relldelem_get__il_relldelem_get_
    {
        [Fact]
        public void _Arrays_misc__il_relldelem_get__il_relldelem_get_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_relldelem_get\\_il_relldelem_get.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
