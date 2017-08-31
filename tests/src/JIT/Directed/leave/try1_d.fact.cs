using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_try1_d_try1_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_try1_d_try1_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\try1_d\\try1_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
