using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__il_dbgbox__il_dbgbox_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__il_dbgbox__il_dbgbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_il_dbgbox\\_il_dbgbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
