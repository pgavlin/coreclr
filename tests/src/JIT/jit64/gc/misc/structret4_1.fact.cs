using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret4_1_structret4_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret4_1_structret4_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret4_1\\structret4_1.cmd");
        }
    }
}
