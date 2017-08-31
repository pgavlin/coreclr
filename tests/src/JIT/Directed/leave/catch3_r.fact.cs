using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _leave_catch3_r_catch3_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch3_r_catch3_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch3_r\\catch3_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
