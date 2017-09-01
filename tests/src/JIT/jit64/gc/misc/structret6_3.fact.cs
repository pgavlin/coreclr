using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _gc_misc_structret6_3_structret6_3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structret6_3_structret6_3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structret6_3\\structret6_3.cmd");
        }
    }
}
