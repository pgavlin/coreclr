using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint64_ro_uint64_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64_ro_uint64_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64_ro\\uint64_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
