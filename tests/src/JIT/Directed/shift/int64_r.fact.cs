using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int64_r_int64_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int64_r_int64_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int64_r\\int64_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
