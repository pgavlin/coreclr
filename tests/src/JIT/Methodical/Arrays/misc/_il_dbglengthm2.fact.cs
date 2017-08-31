using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_dbglengthm2__il_dbglengthm2_
    {
        [Fact]
        public void _Arrays_misc__il_dbglengthm2__il_dbglengthm2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_dbglengthm2\\_il_dbglengthm2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
