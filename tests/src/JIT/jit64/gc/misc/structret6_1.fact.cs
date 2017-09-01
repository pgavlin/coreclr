using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret6_1_structret6_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret6_1_structret6_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret6_1\\structret6_1.cmd");
        }
    }
}
