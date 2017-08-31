using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_filter2_d_filter2_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter2_d_filter2_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter2_d\\filter2_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
