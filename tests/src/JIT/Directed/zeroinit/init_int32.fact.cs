using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _zeroinit_init_int32_init_int32_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_int32_init_int32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_int32\\init_int32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
