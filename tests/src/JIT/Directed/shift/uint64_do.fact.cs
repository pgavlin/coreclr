using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _shift_uint64_do_uint64_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64_do_uint64_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64_do\\uint64_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
