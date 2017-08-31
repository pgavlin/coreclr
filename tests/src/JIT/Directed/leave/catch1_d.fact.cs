using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_catch1_d_catch1_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch1_d_catch1_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch1_d\\catch1_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
