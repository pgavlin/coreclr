using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_ret_struct_test1_ret_struct_test1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_ret_struct_test1_ret_struct_test1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\ret_struct_test1\\ret_struct_test1.cmd");
        }
    }
}
