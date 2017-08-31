using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _zeroinit_init_uint32_init_uint32_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_uint32_init_uint32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_uint32\\init_uint32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
