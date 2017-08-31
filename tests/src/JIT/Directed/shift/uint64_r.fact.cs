using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint64_r_uint64_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64_r_uint64_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64_r\\uint64_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
