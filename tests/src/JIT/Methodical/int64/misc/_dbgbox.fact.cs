using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__dbgbox__dbgbox_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__dbgbox__dbgbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_dbgbox\\_dbgbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
