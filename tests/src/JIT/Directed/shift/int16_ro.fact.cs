using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int16_ro_int16_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_ro_int16_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_ro\\int16_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
