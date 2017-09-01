using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct5_2_struct5_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct5_2_struct5_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct5_2\\struct5_2.cmd");
        }
    }
}
