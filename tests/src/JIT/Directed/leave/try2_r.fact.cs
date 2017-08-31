using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_try2_r_try2_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_try2_r_try2_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\try2_r\\try2_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
