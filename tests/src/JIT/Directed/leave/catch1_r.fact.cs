using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_catch1_r_catch1_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch1_r_catch1_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch1_r\\catch1_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
