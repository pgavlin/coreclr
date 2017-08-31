using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__speed_dbgbox__speed_dbgbox_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__speed_dbgbox__speed_dbgbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_speed_dbgbox\\_speed_dbgbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
