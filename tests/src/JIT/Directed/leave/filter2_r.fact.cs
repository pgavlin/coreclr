using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_filter2_r_filter2_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter2_r_filter2_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter2_r\\filter2_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
