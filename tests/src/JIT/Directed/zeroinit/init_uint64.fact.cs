using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _zeroinit_init_uint64_init_uint64_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_uint64_init_uint64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_uint64\\init_uint64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
