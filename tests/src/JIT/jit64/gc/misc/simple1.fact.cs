using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_simple1_simple1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_simple1_simple1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\simple1\\simple1.cmd");
        }
    }
}
