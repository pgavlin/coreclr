using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_multihandler_do_multihandler_do_
    {
        [Fact]
        public void _eh_basics_multihandler_do_multihandler_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\multihandler_do\\multihandler_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
