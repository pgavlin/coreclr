using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_filter3_r_filter3_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter3_r_filter3_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter3_r\\filter3_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
