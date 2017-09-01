using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct5_struct5_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct5_struct5_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct5\\struct5.cmd");
        }
    }
}
