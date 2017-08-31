using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _zeroinit_tail_tail_
    {
        [Fact]
        public void _zeroinit_tail_tail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\tail\\tail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
