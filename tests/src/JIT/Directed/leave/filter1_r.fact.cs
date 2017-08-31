using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_filter1_r_filter1_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter1_r_filter1_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter1_r\\filter1_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
