using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_catch2_d_catch2_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch2_d_catch2_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch2_d\\catch2_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
