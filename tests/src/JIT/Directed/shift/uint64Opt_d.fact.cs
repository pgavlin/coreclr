using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint64Opt_d_uint64Opt_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64Opt_d_uint64Opt_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64Opt_d\\uint64Opt_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
