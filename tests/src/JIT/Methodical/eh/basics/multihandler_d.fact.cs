using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_multihandler_d_multihandler_d_
    {
        [Fact]
        public void _eh_basics_multihandler_d_multihandler_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\multihandler_d\\multihandler_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
