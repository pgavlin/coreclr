using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_filter3_d_filter3_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter3_d_filter3_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter3_d\\filter3_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
