using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct2_4_struct2_4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct2_4_struct2_4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct2_4\\struct2_4.cmd");
        }
    }
}
