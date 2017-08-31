using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int16_do_int16_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_do_int16_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_do\\int16_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
