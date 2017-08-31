using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint64Opt_r_uint64Opt_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64Opt_r_uint64Opt_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64Opt_r\\uint64Opt_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
