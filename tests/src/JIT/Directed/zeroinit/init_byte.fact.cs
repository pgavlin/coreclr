using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _zeroinit_init_byte_init_byte_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_byte_init_byte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_byte\\init_byte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
