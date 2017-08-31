using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint32_do_uint32_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint32_do_uint32_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint32_do\\uint32_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
