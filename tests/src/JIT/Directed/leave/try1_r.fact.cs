using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_try1_r_try1_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_try1_r_try1_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\try1_r\\try1_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
