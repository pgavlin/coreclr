using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_multihandler_r_multihandler_r_
    {
        [Fact]
        public void _eh_basics_multihandler_r_multihandler_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\multihandler_r\\multihandler_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
