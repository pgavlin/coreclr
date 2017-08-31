using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_filter1_d_filter1_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter1_d_filter1_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter1_d\\filter1_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
