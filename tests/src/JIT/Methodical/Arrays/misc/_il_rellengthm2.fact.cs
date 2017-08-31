using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_rellengthm2__il_rellengthm2_
    {
        [Fact]
        public void _Arrays_misc__il_rellengthm2__il_rellengthm2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_rellengthm2\\_il_rellengthm2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
