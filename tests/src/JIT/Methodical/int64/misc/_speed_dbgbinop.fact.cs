using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__speed_dbgbinop__speed_dbgbinop_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__speed_dbgbinop__speed_dbgbinop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_speed_dbgbinop\\_speed_dbgbinop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
