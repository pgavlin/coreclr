using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_try2_d_try2_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_try2_d_try2_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\try2_d\\try2_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
