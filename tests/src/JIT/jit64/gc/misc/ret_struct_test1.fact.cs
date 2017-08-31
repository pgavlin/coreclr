using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_ret_struct_test1_ret_struct_test1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_ret_struct_test1_ret_struct_test1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\ret_struct_test1\\ret_struct_test1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
