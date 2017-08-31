using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_try3_r_try3_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_try3_r_try3_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\try3_r\\try3_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
