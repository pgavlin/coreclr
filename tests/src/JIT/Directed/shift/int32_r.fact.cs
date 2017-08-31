using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int32_r_int32_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_r_int32_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_r\\int32_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
