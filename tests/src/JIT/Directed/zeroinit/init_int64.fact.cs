using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _zeroinit_init_int64_init_int64_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_int64_init_int64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_int64\\init_int64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
