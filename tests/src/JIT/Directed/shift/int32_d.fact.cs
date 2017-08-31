using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int32_d_int32_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_d_int32_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_d\\int32_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
