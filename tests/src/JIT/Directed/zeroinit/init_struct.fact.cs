using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _zeroinit_init_struct_init_struct_
    {
        [Fact]
        public void _zeroinit_init_struct_init_struct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_struct\\init_struct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
