using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int32_ro_int32_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_ro_int32_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_ro\\int32_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
