using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint64Opt_ro_uint64Opt_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64Opt_ro_uint64Opt_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64Opt_ro\\uint64Opt_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
