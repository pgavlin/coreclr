using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret6_2_structret6_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret6_2_structret6_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret6_2\\structret6_2.cmd");
        }
    }
}
