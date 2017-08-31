using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint16_do_uint16_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_do_uint16_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_do\\uint16_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
