using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct7_1_struct7_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct7_1_struct7_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct7_1\\struct7_1.cmd");
        }
    }
}
