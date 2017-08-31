using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_catch2_r_catch2_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch2_r_catch2_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch2_r\\catch2_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
