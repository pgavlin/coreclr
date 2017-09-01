using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_ret_struct_test4_ret_struct_test4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_ret_struct_test4_ret_struct_test4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\ret_struct_test4\\ret_struct_test4.cmd");
        }
    }
}
