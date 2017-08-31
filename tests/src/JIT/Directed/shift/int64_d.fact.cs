using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int64_d_int64_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int64_d_int64_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int64_d\\int64_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
