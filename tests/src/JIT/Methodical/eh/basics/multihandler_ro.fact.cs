using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_multihandler_ro_multihandler_ro_
    {
        [Fact]
        public void _eh_basics_multihandler_ro_multihandler_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\multihandler_ro\\multihandler_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
