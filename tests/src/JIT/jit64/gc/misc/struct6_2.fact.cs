using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_struct6_2_struct6_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct6_2_struct6_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct6_2\\struct6_2.cmd");
        }
    }
}
