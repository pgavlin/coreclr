using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_int64_do_int64_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int64_do_int64_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int64_do\\int64_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
