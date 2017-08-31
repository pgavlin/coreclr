using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_ret_struct_test4_ret_struct_test4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_ret_struct_test4_ret_struct_test4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\ret_struct_test4\\ret_struct_test4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
