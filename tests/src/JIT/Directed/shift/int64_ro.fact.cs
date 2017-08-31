using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int64_ro_int64_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int64_ro_int64_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int64_ro\\int64_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
