using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret4_2_structret4_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret4_2_structret4_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret4_2\\structret4_2.cmd");
        }
    }
}
