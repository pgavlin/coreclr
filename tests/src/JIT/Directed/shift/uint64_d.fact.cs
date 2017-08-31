using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint64_d_uint64_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64_d_uint64_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64_d\\uint64_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
