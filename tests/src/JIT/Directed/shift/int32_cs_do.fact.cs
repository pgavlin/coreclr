using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int32_cs_do_int32_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_cs_do_int32_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_cs_do\\int32_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
