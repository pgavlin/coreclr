using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct5_5_struct5_5_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct5_5_struct5_5_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct5_5\\struct5_5.cmd");
        }
    }
}
