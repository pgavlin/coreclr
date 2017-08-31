using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_try3_d_try3_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_try3_d_try3_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\try3_d\\try3_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
