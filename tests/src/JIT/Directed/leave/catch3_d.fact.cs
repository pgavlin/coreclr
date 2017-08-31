using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_catch3_d_catch3_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch3_d_catch3_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch3_d\\catch3_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
