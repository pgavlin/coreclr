using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct5_4_struct5_4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct5_4_struct5_4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct5_4\\struct5_4.cmd");
        }
    }
}
