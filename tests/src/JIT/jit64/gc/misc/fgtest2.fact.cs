using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_fgtest2_fgtest2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_fgtest2_fgtest2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\fgtest2\\fgtest2.cmd");
        }
    }
}
